using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebApplicationAdminPanel.Business.Abstract;
using WebApplicationAdminPanel.Business.Concrete;
using WebApplicationAdminPanel.Infrastructer;
using WebApplicationAdminPanel.Utilities;

namespace WebApplicationAdminPanel
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddScoped<AuthenticationStateProvider, AuthStateProvider>();
            builder.Services.AddTransient<IIdentityService, IdentityManager>();
            builder.Services.AddTransient<IProductService, ProductManager>();
            builder.Services.AddTransient<IBasketService, BasketManager>();
            builder.Services.AddTransient<IOrderService, OrderManager>();
            builder.Services.AddSingleton<StateManager>();

            builder.Services.AddScoped<AuthTokenHandler>();
            //builder.Services.AddSingleton<HttpClientDelegatingHandler>();

            builder.Services.AddHttpClient("ApiGatewayHttpClient", client =>
            {
                client.BaseAddress = new Uri("http://localhost:5000/");
            }).AddHttpMessageHandler<AuthTokenHandler>();
            builder.Services.AddScoped(serviceProvider =>
            {
                var clientFactory = serviceProvider.GetRequiredService<IHttpClientFactory>();
                return clientFactory.CreateClient("ApiGatewayHttpClient");
            });

            await builder.Build().RunAsync();
        }
    }
}
