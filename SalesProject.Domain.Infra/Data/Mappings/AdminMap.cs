using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesProject.Domain.Models;

namespace SalesProject.Domain.Infra.Data.Mappings;

public class AdminMap : IEntityTypeConfiguration<Admin>
{
    public void Configure(EntityTypeBuilder<Admin> builder)
    {
        builder.ToTable("Admins");

        builder.HasKey(admin => admin.Id);

        builder.Property(admin => admin.Name).IsRequired().HasColumnName("Name").HasColumnType("NVARCHAR").HasMaxLength(120);
        builder.Property(admin => admin.Email).IsRequired().HasColumnName("Email").HasColumnType("NVARCHAR").HasMaxLength(180);
        builder.Property(admin => admin.PasswordHash).IsRequired().HasColumnName("PasswordHash").HasColumnType("NVARCHAR").HasMaxLength(255);

        builder.HasIndex(admin => admin.Name, "IX_Admin_Name");
        builder.HasIndex(admin => admin.Email, "Ix_Admin_Email");
    }
}