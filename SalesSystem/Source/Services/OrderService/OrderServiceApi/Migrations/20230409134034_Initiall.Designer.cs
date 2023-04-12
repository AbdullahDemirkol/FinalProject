﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using OrderServiceApi.DataAccess;

namespace OrderServiceApi.Migrations
{
    [DbContext(typeof(OrderDbContext))]
    [Migration("20230409134034_Initiall")]
    partial class Initiall
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("OrderServiceApi.Entity.Concrete.Buyer.Buyer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasColumnType("varchar");

                    b.HasKey("Id");

                    b.ToTable("Buyers");
                });

            modelBuilder.Entity("OrderServiceApi.Entity.Concrete.Buyer.PaymentMethod", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Alias")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("Alias");

                    b.Property<Guid>("BuyerId")
                        .HasColumnType("uuid");

                    b.Property<string>("CardHolderName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("CardHolderName");

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("character varying(25)")
                        .HasColumnName("CardNumber");

                    b.Property<int>("CardTypeId")
                        .HasColumnType("integer")
                        .HasColumnName("CardTypeId");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("Expiration")
                        .HasMaxLength(25)
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("Expiration");

                    b.Property<string>("SecurityNumber")
                        .HasColumnType("text");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean")
                        .HasColumnName("Status");

                    b.HasKey("Id");

                    b.HasIndex("BuyerId");

                    b.HasIndex("CardTypeId");

                    b.ToTable("PaymentMethods");
                });

            modelBuilder.Entity("OrderServiceApi.Entity.Concrete.Helper.Enum.CardType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("Id");

                    b.ToTable("CardTypes");
                });

            modelBuilder.Entity("OrderServiceApi.Entity.Concrete.Helper.Enum.OrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("Id");

                    b.ToTable("OrderStatuses");
                });

            modelBuilder.Entity("OrderServiceApi.Entity.Concrete.Order.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("BuyerId")
                        .HasColumnType("uuid");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uuid");

                    b.Property<string>("State")
                        .HasColumnType("text");

                    b.Property<string>("Street")
                        .HasColumnType("text");

                    b.Property<string>("ZipCode")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("OrderServiceApi.Entity.Concrete.Order.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("BuyerId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("OrderStatusId")
                        .HasColumnType("integer")
                        .HasColumnName("OrderStatusId");

                    b.Property<Guid?>("PaymentMethodId")
                        .HasColumnType("uuid");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<int>("orderStatusId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("BuyerId");

                    b.HasIndex("orderStatusId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("OrderServiceApi.Entity.Concrete.Order.OrderItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uuid");

                    b.Property<string>("PictureUrl")
                        .HasColumnType("text");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<string>("ProductName")
                        .HasColumnType("text");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("numeric");

                    b.Property<int>("Units")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("OrderServiceApi.Entity.Concrete.Buyer.PaymentMethod", b =>
                {
                    b.HasOne("OrderServiceApi.Entity.Concrete.Buyer.Buyer", null)
                        .WithMany("_paymentMethods")
                        .HasForeignKey("BuyerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OrderServiceApi.Entity.Concrete.Helper.Enum.CardType", "CardType")
                        .WithMany()
                        .HasForeignKey("CardTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CardType");
                });

            modelBuilder.Entity("OrderServiceApi.Entity.Concrete.Order.Address", b =>
                {
                    b.HasOne("OrderServiceApi.Entity.Concrete.Order.Order", null)
                        .WithOne("Address")
                        .HasForeignKey("OrderServiceApi.Entity.Concrete.Order.Address", "OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OrderServiceApi.Entity.Concrete.Order.Order", b =>
                {
                    b.HasOne("OrderServiceApi.Entity.Concrete.Buyer.Buyer", "Buyer")
                        .WithMany()
                        .HasForeignKey("BuyerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OrderServiceApi.Entity.Concrete.Helper.Enum.OrderStatus", "OrderStatus")
                        .WithMany()
                        .HasForeignKey("orderStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Buyer");

                    b.Navigation("OrderStatus");
                });

            modelBuilder.Entity("OrderServiceApi.Entity.Concrete.Order.OrderItem", b =>
                {
                    b.HasOne("OrderServiceApi.Entity.Concrete.Order.Order", null)
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OrderServiceApi.Entity.Concrete.Buyer.Buyer", b =>
                {
                    b.Navigation("_paymentMethods");
                });

            modelBuilder.Entity("OrderServiceApi.Entity.Concrete.Order.Order", b =>
                {
                    b.Navigation("Address");

                    b.Navigation("OrderItems");
                });
#pragma warning restore 612, 618
        }
    }
}
