using BasketServiceApi.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketServiceApi.DataAccess.PostgreSqlConnect
{
    public class BasketDbContext: DbContext
    {
        public BasketDbContext(DbContextOptions<BasketDbContext> options) :
            base(options)
        { }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.EnableSensitiveDataLogging();
        //}
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseNpgsql("Host=localhost;Database=CatalogDatabase;Username=postgres;Password=1234");
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerBasket>()
                .HasKey(b => b.UserName);
            modelBuilder.Entity<CustomerBasket>()
                .HasMany(b => b.BasketItems)
                .WithOne()
                .HasForeignKey("BasketId");
        }
        public DbSet<CustomerBasket> CustomerBaskets{ get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
    }
}
