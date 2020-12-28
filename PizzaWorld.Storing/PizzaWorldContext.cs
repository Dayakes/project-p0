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


    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        builder.UseSqlServer("Server=darrenpizzaworldp0.database.windows.net;Initial Catalog=PizzaWorldDb;User ID=sqladmin;Password=;");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Store>().HasKey(s => s.StoreId);
        builder.Entity<User>().HasKey(u => u.UserId);
        builder.Entity<APizzaModel>().HasKey(p => p.PizzaId);
        builder.Entity<Crust>().HasKey(c => c.CrustId);
        builder.Entity<Order>().HasKey(o => o.OrderId);
        builder.Entity<Size>().HasKey(si => si.SizeId);
        builder.Entity<Topping>().HasKey(t => t.ToppingId);

        SeedData(builder);
    }
    private void SeedData(ModelBuilder builder)
    {
        builder.Entity<Store>().HasData(new List<Store>
            {
                new Store(){Name = "Dominos"},
                new Store(){Name = "Pizza Hut"}
            }
        );
    }
}
