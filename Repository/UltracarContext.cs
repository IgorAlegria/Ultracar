using Microsoft.EntityFrameworkCore;
using Ultracar.Models;

namespace Ultracar.Repository;
public class UltracarContext : DbContext, IUltracarContext
{
  
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;

        public UltracarContext(DbContextOptions<UltracarContext> options) : base(options) { }
  
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("WebApiDatabase");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>()
            .HasKey(OrderProduct => new {OrderProduct.ProductId, OrderProduct.OrderId});
    }
         

        

}