using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tienda.WebApp.Migrations.SoporteDomainDB
{
    public partial class updatetecnicohorario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "TecnicoId",
                table: "TecnicoHorarios",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TecnicoHorarios_TecnicoId",
                table: "TecnicoHorarios",
                column: "TecnicoId");

            migrationBuilder.AddForeignKey(
                name: "FK_TecnicoHorarios_Tecnicos_TecnicoId",
                table: "TecnicoHorarios",
                column: "TecnicoId",
                principalTable: "Tecnicos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TecnicoHorarios_Tecnicos_TecnicoId",
                table: "TecnicoHorarios");

            migrationBuilder.DropIndex(
                name: "IX_TecnicoHorarios_TecnicoId",
                table: "TecnicoHorarios");

            migrationBuilder.DropColumn(
                name: "TecnicoId",
                table: "TecnicoHorarios");
        }
    }
}
