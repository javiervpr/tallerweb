using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tienda.WebApp.Migrations.SoporteDomainDB
{
    public partial class soporte : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrdenesServicios",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    precio = table.Column<double>(nullable: true),
                    tipoServicio = table.Column<int>(nullable: false),
                    fechaRegistro = table.Column<DateTime>(nullable: false),
                    nombreCliente = table.Column<string>(nullable: true),
                    apellidoCliente = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenesServicios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    nombre = table.Column<string>(nullable: false),
                    categoria = table.Column<string>(nullable: false),
                    descripcion = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TecnicoHorarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    dia = table.Column<int>(nullable: false),
                    horaInicio = table.Column<DateTime>(nullable: false),
                    horaFin = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TecnicoHorarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tecnicos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    nombre = table.Column<string>(nullable: true),
                    apellido = table.Column<string>(nullable: true),
                    especialidad = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tecnicos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Citas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    fechaRegistro = table.Column<DateTime>(nullable: false),
                    fechaTrabajo = table.Column<DateTime>(nullable: false),
                    fechaConfirmacion = table.Column<DateTime>(nullable: true),
                    fechaFinalizacion = table.Column<DateTime>(nullable: true),
                    direccion = table.Column<string>(nullable: true),
                    estado = table.Column<int>(nullable: false),
                    OrdenServicioId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Citas_OrdenesServicios_OrdenServicioId",
                        column: x => x.OrdenServicioId,
                        principalTable: "OrdenesServicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FormularioTrabajos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    comentario = table.Column<string>(nullable: true),
                    OrdenServicioId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormularioTrabajos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormularioTrabajos_OrdenesServicios_OrdenServicioId",
                        column: x => x.OrdenServicioId,
                        principalTable: "OrdenesServicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrdenServicioProductos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    OrdenServicioId = table.Column<Guid>(nullable: true),
                    ProductoId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenServicioProductos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdenServicioProductos_OrdenesServicios_OrdenServicioId",
                        column: x => x.OrdenServicioId,
                        principalTable: "OrdenesServicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdenServicioProductos_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CitaTecnicos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CitaId = table.Column<Guid>(nullable: true),
                    TecnicoId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CitaTecnicos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CitaTecnicos_Citas_CitaId",
                        column: x => x.CitaId,
                        principalTable: "Citas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CitaTecnicos_Tecnicos_TecnicoId",
                        column: x => x.TecnicoId,
                        principalTable: "Tecnicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Citas_OrdenServicioId",
                table: "Citas",
                column: "OrdenServicioId");

            migrationBuilder.CreateIndex(
                name: "IX_CitaTecnicos_CitaId",
                table: "CitaTecnicos",
                column: "CitaId");

            migrationBuilder.CreateIndex(
                name: "IX_CitaTecnicos_TecnicoId",
                table: "CitaTecnicos",
                column: "TecnicoId");

            migrationBuilder.CreateIndex(
                name: "IX_FormularioTrabajos_OrdenServicioId",
                table: "FormularioTrabajos",
                column: "OrdenServicioId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenServicioProductos_OrdenServicioId",
                table: "OrdenServicioProductos",
                column: "OrdenServicioId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenServicioProductos_ProductoId",
                table: "OrdenServicioProductos",
                column: "ProductoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CitaTecnicos");

            migrationBuilder.DropTable(
                name: "FormularioTrabajos");

            migrationBuilder.DropTable(
                name: "OrdenServicioProductos");

            migrationBuilder.DropTable(
                name: "TecnicoHorarios");

            migrationBuilder.DropTable(
                name: "Citas");

            migrationBuilder.DropTable(
                name: "Tecnicos");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "OrdenesServicios");
        }
    }
}
