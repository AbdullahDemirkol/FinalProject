using EventBus.Base.Entity.Abstract;
using EventBus.Base.Entity.Concrete;
using EventBus.Base.EventBus.Abstract;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Base.EventBus.Concrete
{
    public abstract class BaseEventBus : IEventBus
    {

        public EventBusConfig EventBusConfig { get; set; }

        public readonly IServiceProvider _serviceProvider;
        public readonly IEventBusSubscriptionService _subscriptionService;

        protected BaseEventBus(EventBusConfig eventBusConfig, IServiceProvider serviceProvider)
        {
            EventBusConfig = eventBusConfig;
            _serviceProvider = serviceProvider;
            _subscriptionService = new EventBusSubscriptionInMemoryManager(SetEventName);
        }

        public abstract void Subscribe<T, TH>()
            where T : IntegrationEvent
            where TH : IIntegrationEventHandler<T>;


        public abstract void Publish(IntegrationEvent integrationEvent);


        public abstract void UnSubscribe<T, TH>()
            where T : IntegrationEvent
            where TH : IIntegrationEventHandler<T>;


        public virtual string GetSubscriptionName(string eventName)
        {
            return $"{EventBusConfig.SubscriberClientAppName}.{SetEventName(eventName)}";
        }
        public virtual string SetEventName(string eventName)
        {
            if (EventBusConfig.HasEventPrefix())
            {
                eventName = eventName.TrimStart(EventBusConfig.EventNamePrefix.ToArray());
            }
            if (EventBusConfig.HasEventSuffix())
            {
                eventName = eventName.TrimEnd(EventBusConfig.EventNameSuffix.ToArray());
            }
            return eventName;

        }
        public virtual void Dispose()
        {
            EventBusConfig = null;
            _subscriptionService.Clear();
        }


        public async Task<bool> ProcessEvent(string eventName, string message)
        {
            eventName = SetEventName(eventName);
            var process = false;

            var HasSubscriptionsForEvent = _subscriptionService.HasSubscriptionsForEvent(eventName);

            if (HasSubscriptionsForEvent)
            {
                var subscriptionEvents = _subscriptionService.GetHandlerForEvent(eventName);
                using (var scope = _serviceProvider.CreateScope())
                {
                    foreach (SubscriptionInfo subscriptionEvent in subscriptionEvents)
                    {
                        var handler = _serviceProvider.GetService(subscriptionEvent.HandlerType);
                        if (handler == null)
                        {
                            continue;
                        }

                        var eventType = _subscriptionService.GetEventTypeByName($"{EventBusConfig.EventNamePrefix}{eventName}{EventBusConfig.EventNameSuffix}");
                        var integrationEvent = JsonConvert.DeserializeObject(message, eventType);

                        var concreteType = typeof(IIntegrationEventHandler<>).MakeGenericType(eventType);
                        await (Task)concreteType.GetMethod("Handle").Invoke(handler, new object[] { integrationEvent });

                    }
                }
                process = true;
            }
            return process;
        }


    }
}
