using EventBus.Base.Entity.Concrete.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Base.Entity.Concrete
{
    public class EventBusConfig
    {
        public int ConnectionTryCount { get; set; } = 5;
        public string DefaultTopicName { get; set; } = "SalesEventBus";
        public string EventBusConnectionString { get; set; } = string.Empty;
        public string SubscriberClientAppName { get; set; } = string.Empty;
        public string EventNamePrefix { get; set; } = string.Empty;
        public string EventNameSuffix { get; set; } = "IntegrationEvent";
        public EventBusType EventBusType { get; set; } = EventBusType.RabbitMQ;
        public object Connection { get; set; }

        public bool HasEventPrefix()
        {
            return !string.IsNullOrEmpty(EventNamePrefix);
        }
        public bool HasEventSuffix()
        {
            return !string.IsNullOrEmpty(EventNameSuffix);
        }
    }
}
