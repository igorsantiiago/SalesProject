using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesProject.Domain.Models;

namespace SalesProject.Domain.Infra.Data.Mappings;

public class RoleMap : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.ToTable("Roles");

        builder.HasKey(role => role.Id);
        builder.Property(role => role.Id).ValueGeneratedNever();

        builder.Property(role => role.Name).IsRequired().HasColumnName("Name").HasColumnType("NVARCHAR").HasMaxLength(80);
        builder.Property(role => role.Slug).IsRequired().HasColumnName("Slug").HasColumnType("NVARCHAR").HasMaxLength(80);

        builder.HasIndex(role => role.Slug, "IX_Role_Slug");
    }
}
