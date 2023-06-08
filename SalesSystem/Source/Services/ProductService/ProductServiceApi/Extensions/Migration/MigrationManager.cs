using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProductServiceApi.DataAccess;
using ProductServiceApi.Extensions.Migration.MigrationSeeds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductServiceApi.Extensions.Migration
{

    public static class MigrationManager
    {
        public static IHost MigrateDatabase(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                try
                {
                    var productContext = scope.ServiceProvider.GetRequiredService<ProductContext>();

                    if (productContext.Database.ProviderName != "Microsoft.EntityFrameworkCore.InMemory")
                    {
                        productContext.Database.Migrate();
                        ProductContextSeed.SeedAsync(productContext).Wait();
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
                    var productContext = scope.ServiceProvider.GetRequiredService<ProductContext>();
                    //Microsoft.EntityFrameworkCore.InMemory
                    if (productContext.Database.ProviderName != "Microsoft.EntityFrameworkCore.InMemory")
                    {
                        productContext.Database.Migrate();
                        ProductContextSeed.SeedAsync(productContext).Wait();
                    }
                }
                catch (Exception E)
                {
                    var P = E.Message;

                    throw;
                }
            }
            return host;
        }
    }
}
