using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrderServiceApi.Entity.Concrete.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServiceApi.DataAccess.EntityConfigurations
{
    public class OrderEntityConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Ignore(p => p.DomainEvents);
            builder.Property<int>("OrderStatusId").UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("OrderStatusId").IsRequired(); 
            //var navigation = builder.Metadata.FindNavigation(nameof(Order.OrderItems));
            //navigation.SetPropertyAccessMode(PropertyAccessMode.Field);
            builder.HasOne(o => o.Buyer).WithMany().HasForeignKey(i => i.BuyerId);
            builder.HasOne(o => o.OrderStatus).WithMany().HasForeignKey("orderStatusId");
        }
    }
}
