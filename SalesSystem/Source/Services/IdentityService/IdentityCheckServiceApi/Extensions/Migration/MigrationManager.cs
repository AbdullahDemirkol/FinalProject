using IdentityCheckServiceApi.DataAccess;
using IdentityCheckServiceApi.Extensions.Migration.MigrationSeeds;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityCheckServiceApi.Extensions.Migration
{
    public static class MigrationManager
    {
        public static IHost MigrateDatabase(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                try
                {
                    var productContext = scope.ServiceProvider.GetRequiredService<IdentityCheckContext>();

                    if (productContext.Database.ProviderName != "Microsoft.EntityFrameworkCore.InMemory")
                    {
                        productContext.Database.Migrate();
                        IdentityCheckContextSeed.SeedAsync(productContext).Wait();
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
                    var productContext = scope.ServiceProvider.GetRequiredService<IdentityCheckContext>();

                    if (productContext.Database.ProviderName != "Microsoft.EntityFrameworkCore.InMemory")
                    {
                        productContext.Database.Migrate();
                        IdentityCheckContextSeed.SeedAsync(productContext).Wait();
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
