using Microsoft.EntityFrameworkCore;
using SalesProject.Domain.Infra.Data.Mappings;
using SalesProject.Domain.Models;

namespace SalesProject.Domain.Infra.Data;

public class SalesProjectDbContext : DbContext
{
    public SalesProjectDbContext(DbContextOptions<SalesProjectDbContext> options) : base(options)
    {
        
    }
    public DbSet<Admin> Admins { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderProduct> OrderProducts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AdminMap());
        modelBuilder.ApplyConfiguration(new ClientMap());
        modelBuilder.ApplyConfiguration(new ProductMap());
        modelBuilder.ApplyConfiguration(new OrderMap());
    }
}
