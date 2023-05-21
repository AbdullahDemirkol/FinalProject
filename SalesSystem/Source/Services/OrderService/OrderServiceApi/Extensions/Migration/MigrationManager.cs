using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OrderServiceApi.DataAccess;
using OrderServiceApi.Extensions.Migration.MigrationSeeds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServiceApi.Extensions.Migration
{
    public static class MigrationManager
    {
        public static IHost MigrateDatabase(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                try
                {
                    var orderDbContext = scope.ServiceProvider.GetRequiredService<OrderDbContext>();

                    if (orderDbContext.Database.ProviderName != "Microsoft.EntityFrameworkCore.InMemory")
                    {
                        orderDbContext.Database.Migrate();
                        OrderContextSeed.SeedAsync(orderDbContext).Wait();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return host;
        }
        public static IWebHost MigrateDatabase(this IWebHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                try
                {
                    var orderDbContext = scope.ServiceProvider.GetRequiredService<OrderDbContext>();

                    if (orderDbContext.Database.ProviderName != "Microsoft.EntityFrameworkCore.InMemory")
                    {
                        orderDbContext.Database.Migrate();
                        OrderContextSeed.SeedAsync(orderDbContext).Wait();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return host;
        }
    }
}
