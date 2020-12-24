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

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        builder.UseSqlServer("Server=darrenpizzaworldp0.database.windows.net;Initial Catalog=PizzaWorldDb;User ID=sqladmin;Password=Krimson1;");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Store>().HasKey(s => s.EntityId);
        builder.Entity<User>().HasKey(u => u.EntityId);
        builder.Entity<APizzaModel>().HasKey(p => p.EntityId);
        builder.Entity<Crust>().HasKey(c => c.EntityId);
        builder.Entity<Order>().HasKey(o => o.EntityId);
        builder.Entity<Size>().HasKey(si => si.EntityId);
        builder.Entity<Topping>().HasKey(t => t.EntityId);

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
