using BasketServiceApi.DataAccess.PostgreSqlConnect;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketServiceApi.Extensions.Migration
{
    public static class MigrationManager
    {
        public static IWebHost MigrateDatabase(this IWebHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                try
                {
                    var productContext = scope.ServiceProvider.GetRequiredService<BasketDbContext>();

                    if (productContext.Database.ProviderName != "Microsoft.EntityFrameworkCore.InMemory")
                    {
                        productContext.Database.Migrate();
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
