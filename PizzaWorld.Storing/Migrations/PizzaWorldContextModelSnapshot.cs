﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace PizzaWorld.Storing.Migrations
{
    [DbContext(typeof(PizzaWorldContext))]
    partial class PizzaWorldContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("PizzaWorld.Domain.Abstracts.APizzaModel", b =>
                {
                    b.Property<long>("PizzaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("OrderId")
                        .HasColumnType("bigint");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("PizzaId");

                    b.HasIndex("OrderId");

                    b.ToTable("Pizzas");
                });

            modelBuilder.Entity("PizzaWorld.Domain.Models.Order", b =>
                {
                    b.Property<long>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long>("StoreId")
                        .HasColumnType("bigint");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("OrderId");

                    b.HasIndex("StoreId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("PizzaWorld.Domain.Models.Store", b =>
                {
                    b.Property<long>("StoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StoreId");

                    b.ToTable("Stores");

                    b.HasData(
                        new
                        {
                            StoreId = 637452346810403873L,
                            Name = "Dominos"
                        },
                        new
                        {
                            StoreId = 637452346810437163L,
                            Name = "Pizza Hut"
                        });
                });

            modelBuilder.Entity("PizzaWorld.Domain.Models.User", b =>
                {
                    b.Property<long>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 637452346810447383L,
                            Name = "Darren"
                        },
                        new
                        {
                            UserId = 637452346810447648L,
                            Name = "Fred"
                        });
                });

            modelBuilder.Entity("PizzaWorld.Domain.Abstracts.APizzaModel", b =>
                {
                    b.HasOne("PizzaWorld.Domain.Models.Order", null)
                        .WithMany("Pizzas")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("PizzaWorld.Domain.Models.Crust", "Crust", b1 =>
                        {
                            b1.Property<long>("APizzaModelPizzaId")
                                .HasColumnType("bigint");

                            b1.Property<string>("Name")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<double>("Price")
                                .HasColumnType("float");

                            b1.HasKey("APizzaModelPizzaId");

                            b1.ToTable("Crusts");

                            b1.WithOwner()
                                .HasForeignKey("APizzaModelPizzaId");
                        });

                    b.OwnsOne("PizzaWorld.Domain.Models.Size", "Size", b1 =>
                        {
                            b1.Property<long>("APizzaModelPizzaId")
                                .HasColumnType("bigint");

                            b1.Property<string>("Name")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<double>("Price")
                                .HasColumnType("float");

                            b1.HasKey("APizzaModelPizzaId");

                            b1.ToTable("Sizes");

                            b1.WithOwner()
                                .HasForeignKey("APizzaModelPizzaId");
                        });

                    b.OwnsMany("PizzaWorld.Domain.Models.Topping", "Toppings", b1 =>
                        {
                            b1.Property<long>("APizzaModelPizzaId")
                                .HasColumnType("bigint");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .UseIdentityColumn();

                            b1.Property<string>("Name")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("APizzaModelPizzaId", "Id");

                            b1.ToTable("Topping");

                            b1.WithOwner()
                                .HasForeignKey("APizzaModelPizzaId");
                        });

                    b.Navigation("Crust");

                    b.Navigation("Size");

                    b.Navigation("Toppings");
                });

            modelBuilder.Entity("PizzaWorld.Domain.Models.Order", b =>
                {
                    b.HasOne("PizzaWorld.Domain.Models.Store", null)
                        .WithMany("Orders")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaWorld.Domain.Models.User", null)
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PizzaWorld.Domain.Models.Order", b =>
                {
                    b.Navigation("Pizzas");
                });

            modelBuilder.Entity("PizzaWorld.Domain.Models.Store", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("PizzaWorld.Domain.Models.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
