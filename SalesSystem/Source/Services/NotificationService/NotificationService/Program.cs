using EventBus.Base.Entity.Concrete;
using EventBus.Base.Entity.Concrete.Enum;
using EventBus.Base.EventBus.Abstract;
using EventBus.Redirect;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NotificationService.Configuration;
using NotificationService.IntegrationEvents.EventHandlers;
using NotificationService.IntegrationEvents.Events;
using RabbitMQ.Client;
using Serilog;
using Serilog.Sinks.Graylog;
using Serilog.Sinks.Graylog.Core.Transport;
using System;
using System.IO;

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

            //MAİL YADA SMS GÖNDERME SİMİLASYONU

            Log.Information("Sms yada Mail Gönderildi.");
            Console.ReadKey();
        }
        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddLogging(configure => configure.SetMinimumLevel(LogLevel.Information));

            services.AddTransient<OrderPaymentSuccessIntegrationEventHandler>();
            services.AddTransient<OrderPaymentFailedIntegrationEventHandler>();

            services.AddSingleton<IEventBus>(
                serviceProvider =>
                {
                    EventBusConfig eventBusConfig = new EventBusConfig()
                    {
                        ConnectionTryCount = 5,
                        SubscriberClientAppName = "NotificationService",
                        EventBusType = EventBusType.RabbitMQ

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
            Log.Logger = new LoggerConfiguration().WriteTo.Graylog(
                new GraylogSinkOptions()
                {
                    Facility = "NotificationService",
                    HostnameOrAddress = "127.0.0.1",
                    Port = 12201,
                    TransportType = TransportType.Udp
                }).CreateLogger();
        }
    }
}
