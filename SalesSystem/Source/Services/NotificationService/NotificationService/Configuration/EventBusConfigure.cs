using EventBus.Base.Entity.Concrete;
using EventBus.Base.Entity.Concrete.Enum;
using EventBus.Base.EventBus.Abstract;
using EventBus.Redirect;
using Microsoft.Extensions.DependencyInjection;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationService.Configuration
{

    public static class EventBusConfigure
    {
        public static IServiceCollection ConfigureServiceEventBus(this IServiceCollection services)
        {
            services.AddSingleton<IEventBus>(
                serviceProvider =>
                {
                    EventBusConfig eventBusConfig = new()
                    {
                        ConnectionTryCount = 5,
                        EventNameSuffix = "IntegrationEvent",
                        SubscriberClientAppName = "NotificationService",
                        EventBusType = EventBusType.RabbitMQ,
                        Connection = new ConnectionFactory()
                        {
                            HostName = "c_rabbitmq"
                        }
                    };
                    return EventBusRedirect.CreateEventBus(eventBusConfig, serviceProvider);
                }
            );
            return services;
        }
    }
}
