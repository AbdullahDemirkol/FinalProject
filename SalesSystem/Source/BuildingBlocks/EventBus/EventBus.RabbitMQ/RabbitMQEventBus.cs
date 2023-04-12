using EventBus.Base.Entity.Concrete;
using EventBus.Base.EventBus.Concrete;
using Newtonsoft.Json;
using Polly;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using RabbitMQ.Client.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.RabbitMQ
{
    public class RabbitMQEventBus : BaseEventBus
    {
        private readonly IConnectionFactory _connectionFactory;
        private readonly IModel _consumerChannel;
        RabbitMQSeamlessConnection _persistentConnection;

        public RabbitMQEventBus(EventBusConfig eventBusConfig, IServiceProvider serviceProvider) : base(eventBusConfig, serviceProvider)
        {

            if (eventBusConfig.Connection != null)
            {
                var connectionJson = JsonConvert.SerializeObject(EventBusConfig, new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });
                _connectionFactory = JsonConvert.DeserializeObject<ConnectionFactory>(connectionJson);
            }
            else
            {
                _connectionFactory = new ConnectionFactory();
            }
            _persistentConnection = new RabbitMQSeamlessConnection(_connectionFactory, eventBusConfig.ConnectionTryCount);
            _consumerChannel = CreateConsumerChannel();
            _subscriptionService.OnEventRemoved += _subscriptionService_OnEventRemoved;
        }
        private IModel CreateConsumerChannel()
        {
            if (!_persistentConnection.IsConnection())
            {
                _persistentConnection.TryConnection();
            }

            var channel = _persistentConnection.CreateModel();

            channel.ExchangeDeclare(EventBusConfig.DefaultTopicName, "direct");

            return channel;
        }
        private void _subscriptionService_OnEventRemoved(object sender, string eventName)
        {
            eventName = SetEventName(eventName);
            if (!_persistentConnection.IsConnection())
            {
                _persistentConnection.TryConnection();
            }

            _consumerChannel.QueueUnbind(eventName, EventBusConfig.DefaultTopicName, eventName);
            if (_subscriptionService.IsEmpty)
            {
                _consumerChannel.Close();
            }
        }

        public override void Publish(IntegrationEvent integrationEvent)
        {
            if (!_persistentConnection.IsConnection())
            {
                _persistentConnection.TryConnection();
            }

            var policy = Policy.Handle<BrokerUnreachableException>().Or<SocketException>()
                .WaitAndRetry(EventBusConfig.ConnectionTryCount, retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)), (ex, time) =>
                {
                    //log
                });
            var eventName = SetEventName(integrationEvent.GetType().Name);

            _consumerChannel.ExchangeDeclare(exchange: EventBusConfig.DefaultTopicName, type: "direct");
            var messageBody = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(integrationEvent));

            policy.Execute(() => {
                var properties = _consumerChannel.CreateBasicProperties();
                properties.DeliveryMode = 2;

                //_consumerChannel.QueueDeclare(GetSubscriptionName(eventName),true,false,false,null);
                //_consumerChannel.QueueBind(GetSubscriptionName(eventName),EventBusConfig.DefaultTopicName,eventName);
                _consumerChannel.BasicPublish(EventBusConfig.DefaultTopicName, eventName, true, properties, messageBody);
            });
        }

        public override void Subscribe<T, TH>()
        {
            var eventName = SetEventName(typeof(T).Name);

            var hasSubscriptionsForEvent = _subscriptionService.HasSubscriptionsForEvent(eventName);
            if (!hasSubscriptionsForEvent)
            {
                if (!_persistentConnection.IsConnection())
                {
                    _persistentConnection.TryConnection();
                }
                //var x = GetSubscriptionName(eventName);
                _consumerChannel.QueueDeclare(GetSubscriptionName(eventName), true, false, false, null);
                _consumerChannel.QueueBind(GetSubscriptionName(eventName), EventBusConfig.DefaultTopicName, eventName);
            }
            _subscriptionService.AddSubscriptionEvent<T, TH>();
            StartBasicConsume(eventName);

        }
        private void StartBasicConsume(string eventName)
        {
            if (_consumerChannel != null)
            {
                var consumer = new EventingBasicConsumer(_consumerChannel);
                consumer.Received += Consumer_Received;

                _consumerChannel.BasicConsume(GetSubscriptionName(eventName), false, consumer);
            }
        }
        private async void Consumer_Received(object sender, BasicDeliverEventArgs e)
        {
            var eventName = SetEventName(e.RoutingKey);
            var message = Encoding.UTF8.GetString(e.Body.Span);
            try
            {
                await ProcessEvent(eventName, message);
            }
            catch (Exception x)
            { Console.WriteLine(x); }
            _consumerChannel.BasicAck(e.DeliveryTag, false);
        }

        public override void UnSubscribe<T, TH>()
        {
            _subscriptionService.RemoveSubscriptionEvent<T, TH>();
        }
    }
}
