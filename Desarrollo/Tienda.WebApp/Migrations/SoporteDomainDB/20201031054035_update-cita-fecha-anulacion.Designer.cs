﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tienda.Soporte.Infraestructura.Persistence;

namespace Tienda.WebApp.Migrations.SoporteDomainDB
{
    [DbContext(typeof(SoporteDomainDBContext))]
    [Migration("20201031054035_update-cita-fecha-anulacion")]
    partial class updatecitafechaanulacion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Tienda.Soporte.Domain.Model.FormularioTrabajo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("OrdenServicioId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("OrdenServicioId");

                    b.ToTable("FormularioTrabajos");
                });

            modelBuilder.Entity("Tienda.Soporte.Domain.Model.Soporte.Cita", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Estado")
                        .HasColumnName("estado")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaAnulacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaConfirmacion")
                        .HasColumnName("fechaConfirmacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaFinalizacion")
                        .HasColumnName("fechaFinalizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnName("fechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaTrabajo")
                        .HasColumnName("fechaTrabajo")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("OrdenServicioId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("OrdenServicioId");

                    b.ToTable("Citas");
                });

            modelBuilder.Entity("Tienda.Soporte.Domain.Model.Soporte.CitaTecnico", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CitaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TecnicoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CitaId");

                    b.HasIndex("TecnicoId");

                    b.ToTable("CitaTecnicos");
                });

            modelBuilder.Entity("Tienda.Soporte.Domain.Model.Soporte.OrdenServicio", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnName("fechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int>("TipoServicio")
                        .HasColumnName("tipoServicio")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("OrdenesServicios");
                });

            modelBuilder.Entity("Tienda.Soporte.Domain.Model.Soporte.OrdenServicioProducto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("OrdenServicioId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ProductoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("OrdenServicioId");

                    b.HasIndex("ProductoId");

                    b.ToTable("OrdenServicioProductos");
                });

            modelBuilder.Entity("Tienda.Soporte.Domain.Model.Soporte.Producto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnName("categoria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnName("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Tienda.Soporte.Domain.Model.Soporte.Tecnico", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Tecnicos");
                });

            modelBuilder.Entity("Tienda.Soporte.Domain.Model.Soporte.TecnicoHorario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Dia")
                        .HasColumnName("dia")
                        .HasColumnType("int");

                    b.Property<DateTime>("HoraFin")
                        .HasColumnName("horaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HoraInicio")
                        .HasColumnName("horaInicio")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("TecnicoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TecnicoId");

                    b.ToTable("TecnicoHorarios");
                });

            modelBuilder.Entity("Tienda.Soporte.Domain.Model.FormularioTrabajo", b =>
                {
                    b.HasOne("Tienda.Soporte.Domain.Model.Soporte.OrdenServicio", "OrdenServicio")
                        .WithMany()
                        .HasForeignKey("OrdenServicioId");

                    b.OwnsOne("Tienda.Soporte.ValueObjects.ComentarioClienteValue", "Comentario", b1 =>
                        {
                            b1.Property<Guid>("FormularioTrabajoId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Value")
                                .HasColumnName("comentario")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("FormularioTrabajoId");

                            b1.ToTable("FormularioTrabajos");

                            b1.WithOwner()
                                .HasForeignKey("FormularioTrabajoId");
                        });
                });

            modelBuilder.Entity("Tienda.Soporte.Domain.Model.Soporte.Cita", b =>
                {
                    b.HasOne("Tienda.Soporte.Domain.Model.Soporte.OrdenServicio", "OrdenServicio")
                        .WithMany()
                        .HasForeignKey("OrdenServicioId");

                    b.OwnsOne("Tienda.SharedKernel.ValueObjects.Address.AddressValue", "Direccion", b1 =>
                        {
                            b1.Property<Guid>("CitaId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnName("direccion")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("CitaId");

                            b1.ToTable("Citas");

                            b1.WithOwner()
                                .HasForeignKey("CitaId");
                        });
                });

            modelBuilder.Entity("Tienda.Soporte.Domain.Model.Soporte.CitaTecnico", b =>
                {
                    b.HasOne("Tienda.Soporte.Domain.Model.Soporte.Cita", "Cita")
                        .WithMany()
                        .HasForeignKey("CitaId");

                    b.HasOne("Tienda.Soporte.Domain.Model.Soporte.Tecnico", "Tecnico")
                        .WithMany()
                        .HasForeignKey("TecnicoId");
                });

            modelBuilder.Entity("Tienda.Soporte.Domain.Model.Soporte.OrdenServicio", b =>
                {
                    b.OwnsOne("Tienda.SharedKernel.ValueObjects.PersonNameValue", "ApellidoCliente", b1 =>
                        {
                            b1.Property<Guid>("OrdenServicioId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnName("apellidoCliente")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("OrdenServicioId");

                            b1.ToTable("OrdenesServicios");

                            b1.WithOwner()
                                .HasForeignKey("OrdenServicioId");
                        });

                    b.OwnsOne("Tienda.SharedKernel.ValueObjects.PersonNameValue", "NombreCliente", b1 =>
                        {
                            b1.Property<Guid>("OrdenServicioId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnName("nombreCliente")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("OrdenServicioId");

                            b1.ToTable("OrdenesServicios");

                            b1.WithOwner()
                                .HasForeignKey("OrdenServicioId");
                        });

                    b.OwnsOne("Tienda.Soporte.ValueObjects.PrecioServicioValue", "Precio", b1 =>
                        {
                            b1.Property<Guid>("OrdenServicioId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<double>("Value")
                                .HasColumnName("precio")
                                .HasColumnType("float");

                            b1.HasKey("OrdenServicioId");

                            b1.ToTable("OrdenesServicios");

                            b1.WithOwner()
                                .HasForeignKey("OrdenServicioId");
                        });
                });

            modelBuilder.Entity("Tienda.Soporte.Domain.Model.Soporte.OrdenServicioProducto", b =>
                {
                    b.HasOne("Tienda.Soporte.Domain.Model.Soporte.OrdenServicio", "OrdenServicio")
                        .WithMany()
                        .HasForeignKey("OrdenServicioId");

                    b.HasOne("Tienda.Soporte.Domain.Model.Soporte.Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoId");
                });

            modelBuilder.Entity("Tienda.Soporte.Domain.Model.Soporte.Tecnico", b =>
                {
                    b.OwnsOne("Tienda.SharedKernel.ValueObjects.PersonNameValue", "Apellido", b1 =>
                        {
                            b1.Property<Guid>("TecnicoId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnName("apellido")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("TecnicoId");

                            b1.ToTable("Tecnicos");

                            b1.WithOwner()
                                .HasForeignKey("TecnicoId");
                        });

                    b.OwnsOne("Tienda.SharedKernel.ValueObjects.PersonNameValue", "Nombre", b1 =>
                        {
                            b1.Property<Guid>("TecnicoId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnName("nombre")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("TecnicoId");

                            b1.ToTable("Tecnicos");

                            b1.WithOwner()
                                .HasForeignKey("TecnicoId");
                        });

                    b.OwnsOne("Tienda.Soporte.Domain.ValueObjects.EspecialidadTecnicoValue", "Especialidad", b1 =>
                        {
                            b1.Property<Guid>("TecnicoId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnName("especialidad")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("TecnicoId");

                            b1.ToTable("Tecnicos");

                            b1.WithOwner()
                                .HasForeignKey("TecnicoId");
                        });
                });

            modelBuilder.Entity("Tienda.Soporte.Domain.Model.Soporte.TecnicoHorario", b =>
                {
                    b.HasOne("Tienda.Soporte.Domain.Model.Soporte.Tecnico", "Tecnico")
                        .WithMany()
                        .HasForeignKey("TecnicoId");
                });
#pragma warning restore 612, 618
        }
    }
}
