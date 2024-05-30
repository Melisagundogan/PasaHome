﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PasaHome.Migrations
{
    /// <inheritdoc />
    public partial class aDDColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "img",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "img",
                table: "Products");
        }
    }
}
