using EventBus.Base.Entity.Concrete;
using EventBus.Base.Entity.Concrete.Enum;
using EventBus.Base.EventBus.Abstract;
using EventBus.RabbitMQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Redirect
{
    public static class EventBusRedirect
    {
        public static IEventBus CreateEventBus(EventBusConfig eventBusConfig, IServiceProvider serviceProvider)
        {
            switch (eventBusConfig.EventBusType)
            {
                case EventBusType.RabbitMQ:
                    return new RabbitMQEventBus(eventBusConfig, serviceProvider);
                case EventBusType.AzureServiceBus:
                    break;
            }
            return new RabbitMQEventBus(eventBusConfig, serviceProvider); 
        }
    }
}
