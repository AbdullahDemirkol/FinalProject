using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using Ocelot.Provider.Consul;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Web.ApiGateway.Business.Abstract;
using Web.ApiGateway.Business.Concrete;
using Web.ApiGateway.Configurations;
using Web.ApiGateway.Infrastructer;

namespace Web.ApiGateway
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Web.ApiGateway", Version = "v1" });
            });

            services.AddOcelot().AddConsul();
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                 {
                     builder.SetIsOriginAllowed((host) => true)
                     .AllowAnyMethod()
                     .AllowAnyHeader()
                     .AllowCredentials();
                 });
            });
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IBasketService, BasketManager>();
            services.AddTransient<HttpClientDelegatingHandler>();
            services.AddHttpClient("basket", p =>
            {
                p.BaseAddress = new Uri(Configuration["Urls:basket"]);
            }).AddHttpMessageHandler<HttpClientDelegatingHandler>();
            services.AddHttpClient("product", p =>
            {
                p.BaseAddress = new Uri(Configuration["Urls:product"]);
            }); 
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            //services.ConfigureHttpClient(Configuration);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public async void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Web.ApiGateway v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("CorsPolicy");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            await app.UseOcelot();
        }
    }
}
