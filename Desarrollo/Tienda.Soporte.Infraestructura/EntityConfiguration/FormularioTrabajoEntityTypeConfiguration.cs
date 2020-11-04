using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Tienda.Soporte.Domain.Model;

namespace Tienda.Soporte.Infraestructura.EntityConfiguration
{
    public class FormularioTrabajoEntityTypeConfiguration : IEntityTypeConfiguration<FormularioTrabajo>
    {
        public void Configure(EntityTypeBuilder<FormularioTrabajo> builder)
        {
            builder.HasKey(x => x.Id);

            builder.OwnsOne(x => x.Comentario)
                .Property(x => x.Value)
                .HasColumnName("comentario");

            builder.Property(x => x.Satisfecho)
                .HasColumnName("satisfecho")
                .IsRequired();
        }

 
    }
}
