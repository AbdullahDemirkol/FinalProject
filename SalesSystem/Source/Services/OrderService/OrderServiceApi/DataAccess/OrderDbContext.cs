using MediatR;
using Microsoft.EntityFrameworkCore;
using OrderServiceApi.DataAccess.EntityConfigurations;
using OrderServiceApi.Entity.Abstract;
using OrderServiceApi.Entity.Concrete.Buyer;
using OrderServiceApi.Entity.Concrete.Helper.Enum;
using OrderServiceApi.Entity.Concrete.Order;
using OrderServiceApi.Extensions.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OrderServiceApi.DataAccess
{
    public class OrderDbContext : DbContext, IUnitOfWork
    {
        private readonly IMediator _mediator;
        public OrderDbContext() : base()
        { }
        public OrderDbContext(DbContextOptions<OrderDbContext> options, IMediator mediator) : base(options)
        {
            _mediator = mediator;
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<CardType> CardTypes { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }

        public async Task<bool> SaveEntityAsync(CancellationToken cancellationToken = default)
        {
            await _mediator.DispatchDomainEventsAsnyc(this);
            await base.SaveChangesAsync(cancellationToken);
            return true;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AddressEntityConfiguration());
            modelBuilder.ApplyConfiguration(new OrderEntityConfiguration());
            modelBuilder.ApplyConfiguration(new BuyerEntityConfiguration());
            modelBuilder.ApplyConfiguration(new CardTypeEntityConfiguration());
            modelBuilder.ApplyConfiguration(new OrderItemEntityConfiguration());
            modelBuilder.ApplyConfiguration(new OrderStatusEntityConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentMethodEntityConfiguration());
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
