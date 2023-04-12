using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrderServiceApi.Entity.Concrete.Buyer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServiceApi.DataAccess.EntityConfigurations
{
    public class BuyerEntityConfiguration : IEntityTypeConfiguration<Buyer>
    {
        public void Configure(EntityTypeBuilder<Buyer> builder)
        {

            builder.HasKey(b => b.Id);
            builder.Ignore(b => b.DomainEvents);
            //builder.Ignore(b => b._paymentMethods);
            //builder.Ignore(b => b.PaymentMethods);
            builder.Property(b => b.Name).HasColumnType("name").HasColumnType("varchar");
            
        }
    }
}
