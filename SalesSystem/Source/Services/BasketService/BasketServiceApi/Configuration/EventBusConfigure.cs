using BasketServiceApi.IntegrationEvents.EventHandlers;
using BasketServiceApi.IntegrationEvents.Events;
using EventBus.Base.Entity.Concrete;
using EventBus.Base.Entity.Concrete.Enum;
using EventBus.Base.EventBus.Abstract;
using EventBus.Redirect;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketServiceApi.Configuration
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
                        SubscriberClientAppName = "BasketService",
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

        public static IApplicationBuilder ConfigureEventBus(this IApplicationBuilder app, IServiceProvider serviceProvider)
        {
            var eventBus = serviceProvider.GetRequiredService<IEventBus>();
            eventBus.Subscribe<OrderCreatedIntegrationEvent, OrderCreatedIntegrationEventHandler>();
            return app;
        }
    }
}
