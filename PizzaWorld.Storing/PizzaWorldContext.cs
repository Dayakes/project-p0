using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Models;

public class PizzaWorldContext : DbContext
{
    public DbSet<Store> Stores { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Crust> Crusts { get; set; }
    public DbSet<Size> Sizes { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderAPizzaModel> OrderAPizzaModel { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        builder.UseSqlServer("Server=darrenpizzaworldp0.database.windows.net;Initial Catalog=PizzaWorldDb;User ID=sqladmin;Password=;");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Store>().HasKey(s => s.StoreId);
        builder.Entity<User>().HasKey(u => u.UserId);
        builder.Entity<User>()
            .Property(u => u.Name)
            .HasColumnName("Name")
            .IsRequired();

        builder.Entity<APizzaModel>().HasKey(p => p.PizzaId);
        builder.Entity<Crust>().HasKey(c => c.CrustId);
        builder.Entity<Order>().HasKey(o => o.OrderId);
        builder.Entity<Size>().HasKey(si => si.SizeId);
        builder.Entity<Topping>().HasKey(t => t.ToppingId);

        // MANY TO MANY ORDERS TO PIZZAS SETUP HERE
        builder.Entity<OrderAPizzaModel>().HasKey(op => new { op.OrderId, op.PizzaId });
        builder.Entity<OrderAPizzaModel>()
               .HasOne(op => op.Order)
               .WithMany(p => p.OrderAPizzaModel)
               .HasForeignKey(op => op.OrderId);
        builder.Entity<OrderAPizzaModel>()
                .HasOne(op => op.APizzaModel)
                .WithMany(o => o.OrderAPizzaModels)
                .HasForeignKey(op => op.PizzaId);

        // SeedData(builder);
    }
    private void SeedData(ModelBuilder builder)
    {
        // builder.Entity<Store>().HasData(new List<Store>
        //     {
        //         new Store(){Name = "Dominos",StoreId = System.DateTime.Now.Ticks},
        //         new Store(){Name = "Pizza Hut",StoreId = System.DateTime.Now.Ticks}
        //     }
        // );
    }
}
