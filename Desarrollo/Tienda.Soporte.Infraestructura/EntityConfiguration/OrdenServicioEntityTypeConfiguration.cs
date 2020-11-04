using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Tienda.Soporte.Domain.Model.Soporte;

namespace Tienda.Soporte.Infraestructura.EntityConfiguration
{
    public class OrdenServicioEntityTypeConfiguration : IEntityTypeConfiguration<OrdenServicio>
    {
        public void Configure(EntityTypeBuilder<OrdenServicio> builder)
        {
            builder.HasKey(x => x.Id);

            builder.OwnsOne(x => x.Precio)
                .Property(x => x.Value)
                .HasColumnName("precio")
                .IsRequired();

            builder.Property(x => x.TipoServicio)
                .HasColumnName("tipoServicio")
                .IsRequired();

            builder.Property(x => x.FechaRegistro)
                .HasColumnName("fechaRegistro")
                .IsRequired();

            builder.OwnsOne(x => x.NombreCliente)
                .Property(x => x.Value)
                .HasColumnName("nombreCliente")
                .IsRequired();

            builder.OwnsOne(x => x.ApellidoCliente)
                .Property(x => x.Value)
                .HasColumnName("apellidoCliente")
                .IsRequired();

            builder.Ignore(x => x.Productos);
        }
    }
}
