using Polly;
using RabbitMQ.Client;
using RabbitMQ.Client.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.RabbitMQ
{
    public class RabbitMQSeamlessConnection
    {
        private readonly IConnectionFactory _connectionFactory;
        private readonly int _tryCount;
        private IConnection _connection;
        private object _lockObject = new object();
        private bool _isDispose;
        public RabbitMQSeamlessConnection(IConnectionFactory connectionFactory, int tryCount = 5)
        {
            _connectionFactory = connectionFactory;
            _tryCount = tryCount;
        }

        public bool IsConnection()
        {
            bool isConnection = (_connection != null && _connection.IsOpen);
            return isConnection;
        }
        public IModel CreateModel()
        {
            var model = _connection.CreateModel();
            return model;
        }
        public void Dispose()
        {
            _isDispose = true;
            _connection.Dispose();
        }
        public bool TryConnection()
        {
            lock (_lockObject)
            {
                var policy = Policy.Handle<SocketException>().Or<BrokerUnreachableException>()
                    .WaitAndRetry(_tryCount, retryAttemp => TimeSpan.FromSeconds(Math.Pow(2, retryAttemp)), (ex, time) => { });
                policy.Execute(() =>
                {
                    _connection = _connectionFactory.CreateConnection();
                });
                if (IsConnection())
                {
                    _connection.ConnectionShutdown += _connection_ConnectionShutdown;
                    _connection.CallbackException += _connection_CallbackException;
                    _connection.ConnectionBlocked += _connection_ConnectionBlocked;
                    return true;
                }
                return false;
            }
        }

        private void _connection_ConnectionBlocked(object sender, global::RabbitMQ.Client.Events.ConnectionBlockedEventArgs e)
        {
            if (_isDispose)
            {
                return;
            }
            TryConnection();
        }

        private void _connection_CallbackException(object sender, global::RabbitMQ.Client.Events.CallbackExceptionEventArgs e)
        {
            if (_isDispose)
            {
                return;
            }
            TryConnection();
        }

        private void _connection_ConnectionShutdown(object sender, ShutdownEventArgs e)
        {
            if (_isDispose)
            {
                return;
            }
            TryConnection();
        }
    }
}
