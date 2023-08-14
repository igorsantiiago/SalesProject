﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalesProject.Domain.Infra.Data;

#nullable disable

namespace SalesProject.Domain.Infra.Migrations
{
    [DbContext(typeof(SalesProjectDbContext))]
    partial class SalesProjectDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClientProduct", b =>
                {
                    b.Property<Guid>("ClientsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ClientsId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("ClientProduct");
                });

            modelBuilder.Entity("SalesProject.Domain.Models.Admin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(180)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("Email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("Name");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("PasswordHash");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Name" }, "IX_Admin_Name");

                    b.HasIndex(new[] { "Email" }, "Ix_Admin_Email");

                    b.ToTable("Admins", (string)null);
                });

            modelBuilder.Entity("SalesProject.Domain.Models.Client", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(180)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("Email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("Name");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("PhoneNumber");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Email" }, "IX_Client_Email");

                    b.HasIndex(new[] { "Name" }, "IX_Client_Name");

                    b.ToTable("Clients", (string)null);
                });

            modelBuilder.Entity("SalesProject.Domain.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Amount")
                        .HasColumnType("INT")
                        .HasColumnName("Amount");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("Name");

                    b.Property<decimal>("Price")
                        .HasColumnType("DECIMAL")
                        .HasColumnName("Price");

                    b.Property<string>("Tag")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("Tag");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Name" }, "IX_Product_Name");

                    b.HasIndex(new[] { "Tag" }, "IX_Product_Tag");

                    b.ToTable("Products", (string)null);
                });

            modelBuilder.Entity("ClientProduct", b =>
                {
                    b.HasOne("SalesProject.Domain.Models.Client", null)
                        .WithMany()
                        .HasForeignKey("ClientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SalesProject.Domain.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
