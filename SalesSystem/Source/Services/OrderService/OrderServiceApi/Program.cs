using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using OrderServiceApi.Extensions.Migration;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServiceApi
{

    public class Program
    {
        private static string environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
        private static IConfiguration configuration
        {
            get
            {
                return new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile($"Configurations/JsonConfiguration/appsettings.json", optional: false)
                    .AddJsonFile($"Configurations/JsonConfiguration/appsettings.{environment}.json", optional: true)
                    .AddEnvironmentVariables() //ortam deðiþkenlerini ekliyor
                    .Build();
            }
        }
        private static IConfiguration serilogConfiguration
        {
            get
            {
                return new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile($"Configurations/JsonConfiguration/serilog.json", optional: false)
                    .AddJsonFile($"Configurations/JsonConfiguration/serilog.{environment}.json", optional: true)
                    .AddEnvironmentVariables() //ortam deðiþkenlerini ekliyor
                    .Build();
            }
        }
        public static IWebHost BuildWebHost(IConfiguration configuration, string[] args)
        {
            return WebHost.CreateDefaultBuilder()
                //.UseDefaultServiceProvider((context, options) =>
                //{
                //    options.ValidateScopes = false;
                //    options.ValidateOnBuild = false;
                //})
                .ConfigureAppConfiguration(p => p.AddConfiguration(configuration))
                .UseStartup<Startup>()
                .ConfigureLogging(p => p.ClearProviders())
                .UseSerilog()
                .Build();
        }
        public static void Main(string[] args)
        {
            //CreateHostBuilder(args).Build();
            var host = WebBuildHost(configuration, args);
            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(serilogConfiguration)
                .CreateLogger();
            host.MigrateDatabase();
            host.Run();
        }
        public static IWebHost WebBuildHost(IConfiguration configuration, string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(p => p.AddConfiguration(configuration))
                .UseStartup<Startup>()
                .ConfigureLogging(p => p.ClearProviders())
                .UseSerilog()
                .Build();
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
        .ConfigureWebHostDefaults(webBuilder =>
        {
            webBuilder.ConfigureAppConfiguration(p => p.AddConfiguration(configuration));
            webBuilder.UseStartup<Startup>();
            webBuilder.ConfigureLogging(p => p.ClearProviders());
            webBuilder.UseSerilog();
        });
    }
    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        CreateHostBuilder(args)
    //           .Build()
    //           .MigrateDatabase()
    //           .Run();
    //    }

    //    public static IHostBuilder CreateHostBuilder(string[] args) =>
    //        Host.CreateDefaultBuilder(args)
    //            .ConfigureWebHostDefaults(webBuilder =>
    //            {
    //                webBuilder.UseStartup<Startup>();
    //            });
    //}
}
