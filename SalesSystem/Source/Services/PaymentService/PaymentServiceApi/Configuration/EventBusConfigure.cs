using EventBus.Base.Entity.Concrete;
using EventBus.Base.Entity.Concrete.Enum;
using EventBus.Base.EventBus.Abstract;
using EventBus.Redirect;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using PaymentServiceApi.IntegrationEvents.EventHandlers;
using PaymentServiceApi.IntegrationEvents.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentServiceApi.Configuration
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
                        SubscriberClientAppName = "PaymentService",
                        EventBusType = EventBusType.RabbitMQ
                    };
                    return EventBusRedirect.CreateEventBus(eventBusConfig, serviceProvider);
                }
            );
            return services;
        }

        public static IApplicationBuilder ConfigureEventBus(this IApplicationBuilder app)
        {
            var eventBus = app.ApplicationServices.GetRequiredService<IEventBus>();
            eventBus.Subscribe<OrderStartedIntegrationEvent, OrderStartedIntegrationEventHandler>();
            return app;
        }
    }
}
