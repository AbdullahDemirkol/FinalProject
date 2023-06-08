using BasketServiceApi.Business.Abstract;
using BasketServiceApi.Business.Concrete;
using BasketServiceApi.Configuration;
using BasketServiceApi.DataAccess.Abstract;
using BasketServiceApi.DataAccess.Concrete;
using BasketServiceApi.DataAccess.PostgreSqlConnect;
using BasketServiceApi.IntegrationEvents.EventHandlers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketServiceApi
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
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "BasketServiceApi", Version = "v1" });
            });

            //-----------------------------------------------------------------


            var p = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<BasketDbContext>(options => options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));

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

            services.AddLogging(configure => configure.AddConsole() /*{ configure.AddConsole();configure.SetMinimumLevel(LogLevel.Debug); }*/) ;

            services.ConfigureAuthentication(Configuration);

            services.ConfigureServiceEventBus();

            services.ConfigurationServiceInConsul(Configuration);

            services.AddSingleton(serviceProvider => serviceProvider.RegisterInRedis(Configuration));

            services.AddHttpContextAccessor();
            services.AddTransient<IBasketRepository, RedisBasketRepository>();
            services.AddTransient<IBasketService, BasketManager>();
            services.AddTransient<IIdentityService, IdentityManager>();
            services.AddTransient<OrderCreatedIntegrationEventHandler>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IHostApplicationLifetime lifetime)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BasketServiceApi v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("CorsPolicy");

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            //-----------------------------------------------------------------

            app.ConfigureEventBus(app.ApplicationServices);
            app.ConfigurationInConsul(lifetime,Configuration);
        }
    }
}
