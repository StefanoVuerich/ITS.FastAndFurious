﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITS.FastAndFurious.Migrations
{
    /// <inheritdoc />
    public partial class ProductOrigin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Origin",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Origin",
                table: "Product");
        }
    }
}
