using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tienda.WebApp.Migrations.SoporteDomainDB
{
    public partial class updatecitafechaanulacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaAnulacion",
                table: "Citas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaAnulacion",
                table: "Citas");
        }
    }
}
