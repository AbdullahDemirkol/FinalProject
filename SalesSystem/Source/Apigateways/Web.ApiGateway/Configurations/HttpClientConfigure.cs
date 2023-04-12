using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.ApiGateway.Infrastructer;

namespace Web.ApiGateway.Configurations
{
    public static class HttpClientConfigure
    {
        public static void ConfigureHttpClient(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<HttpClientDelegatingHandler>();
            services.AddHttpClient("basket", httpClient =>
            {
                httpClient.BaseAddress = new Uri(configuration["Urls:BasketService"]);
            }).AddHttpMessageHandler<HttpClientDelegatingHandler>();
            services.AddHttpClient("product", client =>
            {
                client.BaseAddress = new Uri(configuration["Urls:ProductService"]);
            });
            //services.AddHttpClient("picture", client =>
            //{
            //    client.BaseAddress = new Uri(configuration["Urls:PictureService"]);
            //}).AddHttpMessageHandler<HttpClientDelegatingHandler>();
        }
    }
}
