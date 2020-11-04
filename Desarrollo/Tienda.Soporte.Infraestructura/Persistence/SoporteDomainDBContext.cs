using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Tienda.Soporte.Domain.Model;
using Tienda.Soporte.Domain.Model.Soporte;
using Tienda.Soporte.Infraestructura.EntityConfiguration;

namespace Tienda.Soporte.Infraestructura.Persistence
{
    public class SoporteDomainDBContext: DbContext
    {
        public DbSet<Tecnico> Tecnicos { get; set; }
        public DbSet<TecnicoHorario> TecnicoHorarios { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<OrdenServicio> OrdenesServicios { get; set; }
        public DbSet<FormularioTrabajo> FormularioTrabajos { get; set; }
        public DbSet<OrdenServicioProducto> OrdenServicioProductos { get; set; }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<CitaTecnico> CitaTecnicos { get; set; }

        public SoporteDomainDBContext(DbContextOptions<SoporteDomainDBContext> options): base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new TecnicoEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TecnicoHorarioEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ProductoEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new OrdenServicioEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new FormularioTrabajoEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new OrdenServicioProductoEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CitaEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CitaTecnicoEntityTypeConfiguration());
        }
    }
}
