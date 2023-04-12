using Consul;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace ProductServiceApi.Configuration
{
    public static class RegisteringServiceIntheConsul
    {
        public static IServiceCollection ConfigurationServiceInConsul(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddSingleton<IConsulClient, ConsulClient>(
                p => new ConsulClient(
                    consulConfig =>
                    {
                        var address = configuration["ConsulConfig:Address"];
                        consulConfig.Address = new Uri(address);
                    }));
            return services;
        }
        public static IApplicationBuilder ConfigurationInConsul(this IApplicationBuilder app, IHostApplicationLifetime lifetime)
        {
            var consulClient = app.ApplicationServices.GetRequiredService<IConsulClient>();

            var loggingFactory = app.ApplicationServices.GetRequiredService<ILoggerFactory>();

            var logger = loggingFactory.CreateLogger<IApplicationBuilder>();

            //IHttpConnectionFeature connection = app..GetFeature<IHttpConnectionFeature>();
            //string ipAddress = connection != null
            //    ? connection.RemoteIpAddress.ToString()
            //    : null;

            //await ctx.Response.WriteAsync("IP Address: " + ipAddress);

            var features = app.Properties["server.Features"] as FeatureCollection;
            var addresses = features.Get<IServerAddressesFeature>().Addresses;
            var address = addresses.First();

            var uri = new Uri(address);
            var registration = new AgentServiceRegistration()
            {
                ID = "ProductService",
                Name = "ProductService",
                Address = $"{uri.Host}",
                Port = uri.Port,
                Tags = new[] { "ProductService", "Product" }
            };

            logger.LogInformation("Consula kayıt oluşturuluyor.");
            consulClient.Agent.ServiceDeregister(registration.ID).Wait();
            consulClient.Agent.ServiceRegister(registration).Wait();

            lifetime.ApplicationStopping.Register(
                () =>
                {
                    logger.LogInformation("Consul kaydı siliniyor.");
                    consulClient.Agent.ServiceDeregister(registration.ID).Wait();
                }
                );
            return app;

        }
    }
}
