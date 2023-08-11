using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesProject.Domain.Models;

namespace SalesProject.Domain.Infra.Data.Mappings;

public class ClientMap : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder.ToTable("Clients");

        builder.HasKey(client => client.Id);
        builder.Property(client => client.Id).ValueGeneratedNever();

        builder.Property(client => client.Name).IsRequired().HasColumnName("Name").HasColumnType("NVARCHAR").HasMaxLength(120);
        builder.Property(client => client.Email).IsRequired().HasColumnName("Email").HasColumnType("NVARCHAR").HasMaxLength(180);
        builder.Property(client => client.PhoneNumber).IsRequired().HasColumnName("PhoneNumber").HasColumnType("NVARCHAR").HasMaxLength(32);

        builder.HasMany(client => client.Products).WithMany(product => product.Clients);

        builder.HasIndex(client => client.Name, "IX_Client_Name");
        builder.HasIndex(client => client.Email, "IX_Client_Email");
    }
}
