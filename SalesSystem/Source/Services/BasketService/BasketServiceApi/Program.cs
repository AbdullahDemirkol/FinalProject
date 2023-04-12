using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BasketServiceApi
{
    public class Program
    {
        private static string env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
        private static IConfiguration configuration
        {
            get
            {
                return new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile($"Configurations/appsettings.json", optional: false)
                    .AddJsonFile($"Configurations/appsettings.{env}.json", optional: true)
                    .AddEnvironmentVariables()
                    .Build();
            }
        }
        private static IConfiguration serilogConfiguration
        {
            get
            {
                return new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile($"Configurations/serilog.json", optional: false)
                    .AddJsonFile($"Configurations/serilog.{env}.json", optional: true)
                    .AddEnvironmentVariables()
                    .Build();
            }
        }
        public static IWebHost BuildWebHost(IConfiguration configuration,string[] args)
        {
            return WebHost.CreateDefaultBuilder()
                .ConfigureAppConfiguration(p=>p.AddConfiguration(configuration))
                .UseStartup<Startup>()
                .ConfigureLogging(p=>p.ClearProviders())
                .UseSerilog()
                .Build();
        }
        public static void Main(string[] args)
        {
            //CreateHostBuilder(args).Build();
            var host = BuildWebHost(configuration,args);
            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(serilogConfiguration)
                .CreateLogger();

            host.Run();  
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.ConfigureAppConfiguration(p => p.AddConfiguration(configuration));
                    webBuilder.UseStartup<Startup>();
                    webBuilder.ConfigureLogging(p => p.ClearProviders());
                    webBuilder.UseSerilog();
                    webBuilder.Build();
                });
    }
}
