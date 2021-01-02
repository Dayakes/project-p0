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
    public DbSet<APizzaModel> Pizzas { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        builder.UseSqlServer("Server=darrenpizzaworldp0.database.windows.net;Initial Catalog=PizzaWorldDb;User ID=sqladmin;Password=;");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Store>().HasKey(s => s.StoreId);

        builder.Entity<Order>().HasKey(o => o.OrderId);

        builder.Entity<User>().HasKey(u => u.UserId);
        builder.Entity<User>()
            .Property(u => u.Name)
            .HasColumnName("Name")
            .IsRequired();

        builder.Entity<APizzaModel>().HasKey(p => p.PizzaId);
        builder.Entity<APizzaModel>().OwnsOne(p => p.Crust);
            // {
            //     c.WithOwner().HasForeignKey("PizzaId");
            //     c.Property<long>("CrustId");
            //     c.HasKey("CrustId");
            // });
        builder.Entity<APizzaModel>().OwnsOne(p => p.Size);
            // {
            //     s.WithOwner().HasForeignKey("PizzaId");
            //     s.Property<long>("SizeId");
            //     s.HasKey("SizeId");
            // });
        builder.Entity<APizzaModel>().OwnsMany(p => p.Toppings);
            // {
            //   t.WithOwner().HasForeignKey("PizzaId");
            //   t.Property<long>("ToppingId");
            //   t.HasKey("ToppingId");
            // });

        
        SeedData(builder);
    }
    private void SeedData(ModelBuilder builder)
    {
        builder.Entity<Store>().HasData(new List<Store>
            {
                new Store(){Name = "Dominos",StoreId = System.DateTime.Now.Ticks},
                new Store(){Name = "Pizza Hut",StoreId = System.DateTime.Now.Ticks}
            }
        );
    }
}
