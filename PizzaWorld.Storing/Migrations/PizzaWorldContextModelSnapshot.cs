﻿// <auto-generated />
using System;
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
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long?>("OrderEntityId")
                        .HasColumnType("bigint");

                    b.Property<long?>("UserEntityId")
                        .HasColumnType("bigint");

                    b.Property<long?>("crustEntityId")
                        .HasColumnType("bigint");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.Property<long?>("sizeEntityId")
                        .HasColumnType("bigint");

                    b.HasKey("EntityId");

                    b.HasIndex("OrderEntityId");

                    b.HasIndex("UserEntityId");

                    b.HasIndex("crustEntityId");

                    b.HasIndex("sizeEntityId");

                    b.ToTable("APizzaModel");
                });

            modelBuilder.Entity("PizzaWorld.Domain.Models.Crust", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EntityId");

                    b.ToTable("Crusts");
                });

            modelBuilder.Entity("PizzaWorld.Domain.Models.Order", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long?>("StoreEntityId")
                        .HasColumnType("bigint");

                    b.Property<long?>("UserEntityId")
                        .HasColumnType("bigint");

                    b.HasKey("EntityId");

                    b.HasIndex("StoreEntityId");

                    b.HasIndex("UserEntityId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("PizzaWorld.Domain.Models.Size", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EntityId");

                    b.ToTable("Sizes");
                });

            modelBuilder.Entity("PizzaWorld.Domain.Models.Store", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EntityId");

                    b.ToTable("Stores");

                    b.HasData(
                        new
                        {
                            EntityId = 637444112884488130L,
                            Name = "Dominos"
                        },
                        new
                        {
                            EntityId = 637444112884520138L,
                            Name = "Pizza Hut"
                        });
                });

            modelBuilder.Entity("PizzaWorld.Domain.Models.Topping", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long?>("APizzaModelEntityId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EntityId");

                    b.HasIndex("APizzaModelEntityId");

                    b.ToTable("Topping");
                });

            modelBuilder.Entity("PizzaWorld.Domain.Models.User", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long?>("SelectedStoreEntityId")
                        .HasColumnType("bigint");

                    b.HasKey("EntityId");

                    b.HasIndex("SelectedStoreEntityId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PizzaWorld.Domain.Abstracts.APizzaModel", b =>
                {
                    b.HasOne("PizzaWorld.Domain.Models.Order", null)
                        .WithMany("Pizzas")
                        .HasForeignKey("OrderEntityId");

                    b.HasOne("PizzaWorld.Domain.Models.User", null)
                        .WithMany("SelectedPizzas")
                        .HasForeignKey("UserEntityId");

                    b.HasOne("PizzaWorld.Domain.Models.Crust", "crust")
                        .WithMany()
                        .HasForeignKey("crustEntityId");

                    b.HasOne("PizzaWorld.Domain.Models.Size", "size")
                        .WithMany()
                        .HasForeignKey("sizeEntityId");

                    b.Navigation("crust");

                    b.Navigation("size");
                });

            modelBuilder.Entity("PizzaWorld.Domain.Models.Order", b =>
                {
                    b.HasOne("PizzaWorld.Domain.Models.Store", null)
                        .WithMany("Orders")
                        .HasForeignKey("StoreEntityId");

                    b.HasOne("PizzaWorld.Domain.Models.User", null)
                        .WithMany("Orders")
                        .HasForeignKey("UserEntityId");
                });

            modelBuilder.Entity("PizzaWorld.Domain.Models.Topping", b =>
                {
                    b.HasOne("PizzaWorld.Domain.Abstracts.APizzaModel", null)
                        .WithMany("toppings")
                        .HasForeignKey("APizzaModelEntityId");
                });

            modelBuilder.Entity("PizzaWorld.Domain.Models.User", b =>
                {
                    b.HasOne("PizzaWorld.Domain.Models.Store", "SelectedStore")
                        .WithMany()
                        .HasForeignKey("SelectedStoreEntityId");

                    b.Navigation("SelectedStore");
                });

            modelBuilder.Entity("PizzaWorld.Domain.Abstracts.APizzaModel", b =>
                {
                    b.Navigation("toppings");
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

                    b.Navigation("SelectedPizzas");
                });
#pragma warning restore 612, 618
        }
    }
}
