using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesProject.Domain.Models;

namespace SalesProject.Domain.Infra.Data.Mappings;

public class UserMap : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");

        builder.HasKey(user => user.Id);
        builder.Property(user => user.Id).ValueGeneratedNever();

        builder.Property(user => user.Name).IsRequired().HasColumnName("Name").HasColumnType("NVARCHAR").HasMaxLength(120);
        builder.Property(user => user.Email).IsRequired().HasColumnName("Email").HasColumnType("NVARCHAR").HasMaxLength(180);
        builder.Property(user => user.PhoneNumber).IsRequired().HasColumnName("PhoneNumber").HasColumnType("NVARCHAR").HasMaxLength(32);
        builder.Property(user => user.PasswordHash).IsRequired().HasColumnName("PasswordHash").HasColumnType("NVARCHAR").HasMaxLength(255);

        builder.HasOne(user => user.Role).WithMany(role => role.Users).HasForeignKey(user => user.RoleId);

        builder.HasIndex(user => user.Name, "IX_User_Name");
        builder.HasIndex(user => user.Email, "IX_User_Email");
    }
}
