using EventBus.Base.Entity.Concrete;
using EventBus.Base.Entity.Concrete.Enum;
using EventBus.Base.EventBus.Abstract;
using EventBus.Redirect;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NotificationService.Configuration;
using NotificationService.IntegrationEvents.EventHandlers;
using NotificationService.IntegrationEvents.Events;
using System;

namespace NotificationService
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceCollection serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            var serviceProvider = serviceCollection.BuildServiceProvider();
            IEventBus eventBus = serviceProvider.GetRequiredService<IEventBus>();

            eventBus.Subscribe<OrderPaymentFailedIntegrationEvent, OrderPaymentFailedIntegrationEventHandler>();
            eventBus.Subscribe<OrderPaymentSuccessIntegrationEvent, OrderPaymentSuccessIntegrationEventHandler>();



            Console.WriteLine("Application çalışıyor...");
            Console.ReadLine();
        }
        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddLogging(configure => {
                configure.AddConsole();
            });
            services.AddTransient<OrderPaymentSuccessIntegrationEventHandler>();
            services.AddTransient<OrderPaymentFailedIntegrationEventHandler>();

            services.AddSingleton<IEventBus>(
                serviceProvider =>
                {
                    EventBusConfig eventBusConfig = new EventBusConfig()
                    {
                        ConnectionTryCount = 5,
                        SubscriberClientAppName = "NotificationService",
                        EventBusType = EventBusType.RabbitMQ,

                        //Connection=new ConnectionFactory()
                        //{
                        //    HostName="localhost",
                        //    Port=5672,
                        //    UserName="guest",
                        //    Password="guest"
                        //}
                    };
                    return EventBusRedirect.CreateEventBus(eventBusConfig, serviceProvider);
                }
            );

        }
    }
}
