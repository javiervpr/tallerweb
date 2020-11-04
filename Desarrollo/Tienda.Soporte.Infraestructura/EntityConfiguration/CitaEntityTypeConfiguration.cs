using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Tienda.Soporte.Domain.Model.Soporte;

namespace Tienda.Soporte.Infraestructura.EntityConfiguration
{
    public class CitaEntityTypeConfiguration : IEntityTypeConfiguration<Cita>
    {
        public void Configure(EntityTypeBuilder<Cita> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.FechaRegistro)
                .HasColumnName("fechaRegistro")
                .IsRequired();

            builder.Property(x => x.FechaTrabajo)
                .HasColumnName("fechaTrabajo");

            builder.Property(x => x.FechaConfirmacion)
                .HasColumnName("fechaConfirmacion");

            builder.Property(x => x.FechaFinalizacion)
                .HasColumnName("fechaFinalizacion");


            builder.OwnsOne(x => x.Direccion)
                .Property(x => x.Value)
                .IsRequired()
                .HasColumnName("direccion");

            builder.Property(x => x.Estado)
                .HasColumnName("estado")
                .IsRequired();

            builder.Ignore(x => x.Tecnicos);
        }
    }
}
