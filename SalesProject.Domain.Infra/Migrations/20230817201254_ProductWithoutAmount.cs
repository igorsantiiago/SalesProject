﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesProject.Domain.Infra.Migrations
{
    /// <inheritdoc />
    public partial class ProductWithoutAmount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Products");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "Products",
                type: "INT",
                nullable: false,
                defaultValue: 0);
        }
    }
}
