using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrderServiceApi.Entity.Concrete.Buyer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServiceApi.DataAccess.EntityConfigurations
{

    public class PaymentMethodEntityConfiguration : IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> builder)
        {
            builder.Property(pm => pm.Id).ValueGeneratedOnAdd();
            builder.HasKey(pm => pm.Id);
            builder.Ignore(pm => pm.DomainEvents);
            //builder.Property(pm => pm.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property<Guid>("BuyerId").IsRequired();
            builder.Property(pm => pm.CardHolderName).UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("CardHolderName")
                .HasMaxLength(200).IsRequired();

            builder.Property(pm => pm.Alias).UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("Alias")
                .HasMaxLength(200)/*.IsRequired()*/;

            builder.Property(pm => pm.CardNumber).UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("CardNumber")
                .HasMaxLength(25).IsRequired();

            builder.Property(pm => pm.Expiration).UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("Expiration")
                .HasMaxLength(25).IsRequired();

            builder.Property(pm => pm.CardTypeId).UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("CardTypeId").IsRequired();
            builder.Property(pm => pm.Status).UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("Status").IsRequired();
            //builder.HasOne(pm=>pm.Buyer).WithMany().HasForeignKey(b=>b.BuyerId);
            builder.HasOne(pm => pm.CardType).WithMany().HasForeignKey(i => i.CardTypeId);
            //builder.HasOne("BuyerId").WithMany().HasForeignKey("BuyerId");
            //builder.Ignore(pm => pm.Buyer);

        }
    }
}
