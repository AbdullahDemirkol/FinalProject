using IdentityCheckServiceApi.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityCheckServiceApi.DataAccess
{
    public class IdentityCheckContext : DbContext
    {
        public IdentityCheckContext(DbContextOptions<IdentityCheckContext> options) :
            base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<UserModel>()
            //    .HasOne(u => u.Role)
            //    .WithOne()
            //    .HasForeignKey<UserModel>(u => u.RoleId);
            base.OnModelCreating(modelBuilder);
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseNpgsql("Host=localhost;Database=CatalogDatabase;Username=postgres;Password=1234");
        //}
        public DbSet<UserModel> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
