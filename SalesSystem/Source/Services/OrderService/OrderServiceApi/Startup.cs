using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using OrderServiceApi.Configurations;
using OrderServiceApi.DataAccess;
using OrderServiceApi.DataAccess.Repositories.Abstract;
using OrderServiceApi.DataAccess.Repositories.Concrete;
using OrderServiceApi.Entity.Concrete.Order;
using OrderServiceApi.IntegrationEvents.EventHandlers;
using OrderServiceApi.IntegrationEvents.QueriesFeatures.Command;
using OrderServiceApi.IntegrationEvents.QueriesFeatures.Command.CommandHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace OrderServiceApi
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
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "OrderServiceApi", Version = "v1" });
            });

            //-----------------------------------------------------------------
            services.AddScoped<IBuyerRepository, BuyerRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IPaymentMethodRepository, PaymentMethodRepository>();
            services.AddMediatR(Assembly.GetExecutingAssembly(), typeof(CreateOrderCommandHandler).GetTypeInfo().Assembly);
            services.AddDbContext<OrderDbContext>(optionsBuilder =>
            {
                var connectionString = Configuration.GetConnectionString("DefaultConnection");

                optionsBuilder.UseNpgsql(connectionString);
                    //.ConfigureWarnings(warnings => warnings.Ignore());

                //optionsBuilder.ReplaceService<IModelCacheKeyFactory, SnakeCaseModelCacheKeyFactory>();
                //optionsBuilder.ReplaceService<INpgsqlModelSource, SnakeCaseNpgsqlModelSource>();
            });


            services.AddTransient<OrderStartedDomainEventHandler>();
            services.AddTransient<OrderCreatedIntegrationEventHandler>();
            services.AddTransient<UpdateOrderWhenBuyerAndPaymentVerifiedDomainEventHandler>();
            services.ConfigureAuthentication(Configuration);
            services.ConfigurationServiceInConsul(Configuration);
            services.ConfigureServiceEventBus();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IHostApplicationLifetime lifetime)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "OrderServiceApi v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            //-----------------------------------------------------------------

            app.ConfigureEventBus();
            app.ConfigurationInConsul(lifetime);
        }
    }
}
