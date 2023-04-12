using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrderServiceApi.Entity.Concrete.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServiceApi.DataAccess.EntityConfigurations
{
    public class AddressEntityConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Ignore(a => a.DomainEvents);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property<Guid>("OrderId").IsRequired();
            //builder.Property<Guid>("BuyerId").IsRequired();
        }
    }
}
