using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesProject.Domain.Models;
using System.Reflection.Emit;

namespace SalesProject.Domain.Infra.Data.Mappings;

public class OrderMap : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.ToTable("Orders");

        builder.HasKey(order => order.Id);
        builder.Property(order => order.Id).ValueGeneratedNever();

        builder.Property(order => order.CreatedAt).IsRequired().HasColumnName("CreatedAt").HasColumnType("SMALLDATETIME");
        builder.Property(order => order.TotalPrice).IsRequired().HasColumnName("TotalPrice").HasColumnType("DECIMAL");

        builder.HasMany(x => x.Products).WithMany(x => x.Orders).UsingEntity<OrderProduct>(x=>x.Property(x=>x.CreatedOn).HasDefaultValueSql("GETUTCDATE()"));

        builder.HasOne(x => x.Client).WithMany(x => x.Orders).HasForeignKey(x => x.ClientId);
    }
}
