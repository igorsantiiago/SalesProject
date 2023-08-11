using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesProject.Domain.Models;

namespace SalesProject.Domain.Infra.Data.Mappings;

public class ProductMap : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Products");

        builder.HasKey(product => product.Id);
        builder.Property(product => product.Id).ValueGeneratedNever();

        builder.Property(product => product.Name).IsRequired().HasColumnName("Name").HasColumnType("NVARCHAR").HasMaxLength(120);
        builder.Property(product => product.Description).IsRequired().HasColumnName("Description").HasColumnType("NVARCHAR");
        builder.Property(product => product.Price).IsRequired().HasColumnName("Price").HasColumnType("DECIMAL");
        builder.Property(product => product.Amount).IsRequired().HasColumnName("Amount").HasColumnType("INT");
        builder.Property(product => product.Tag).IsRequired().HasColumnName("Tag").HasColumnType("NVARCHAR").HasMaxLength(40);

        builder.HasIndex(product => product.Name, "IX_Product_Name");
        builder.HasIndex(product => product.Tag, "IX_Product_Tag");
    }
}
