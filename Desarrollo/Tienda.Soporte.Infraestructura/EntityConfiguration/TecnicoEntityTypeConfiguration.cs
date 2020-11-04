using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Tienda.Soporte.Domain.Model.Soporte;

namespace Tienda.Soporte.Infraestructura.EntityConfiguration
{
    public class TecnicoEntityTypeConfiguration : IEntityTypeConfiguration<Tecnico>
    {
        public void Configure(EntityTypeBuilder<Tecnico> builder)
        {
            builder.HasKey(x => x.Id);


            builder.OwnsOne(x => x.Nombre)
                .Property(x => x.Value)
                .HasColumnName("nombre")
                .IsRequired();

            builder.OwnsOne(x => x.Apellido)
                .Property(x => x.Value)
               .HasColumnName("apellido")
               .IsRequired();

            builder.OwnsOne(x => x.Especialidad)
                .Property(x => x.Value)
               .HasColumnName("especialidad")
               .IsRequired();
        }
    }
}
