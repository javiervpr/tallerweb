using Microsoft.EntityFrameworkCore.Migrations;

namespace Tienda.WebApp.Migrations.SoporteDomainDB
{
    public partial class formulariotrabajosatisfechocolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "satisfecho",
                table: "FormularioTrabajos",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "satisfecho",
                table: "FormularioTrabajos");
        }
    }
}
