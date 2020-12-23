using Microsoft.EntityFrameworkCore;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Models;

public class PizzaWorldContext : DbContext
{
    public DbSet<Store> Stores { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        builder.UseSqlServer("Server=darrenpizzaworldp0.database.windows.net;Initial Catalog=PizzaWorldDb;User ID=sqladmin;Password=password;");
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
    }
}
