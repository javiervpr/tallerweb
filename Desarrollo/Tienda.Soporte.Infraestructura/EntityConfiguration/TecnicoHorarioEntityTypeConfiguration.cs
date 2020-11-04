using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Tienda.Soporte.Domain.Model.Soporte;

namespace Tienda.Soporte.Infraestructura.EntityConfiguration
{
    public class TecnicoHorarioEntityTypeConfiguration : IEntityTypeConfiguration<TecnicoHorario>
    {
        public void Configure(EntityTypeBuilder<TecnicoHorario> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Dia)
                .HasColumnName("dia")
                .IsRequired();

            builder.Property(x => x.HoraInicio)
                .HasColumnName("horaInicio")
                .IsRequired();

            builder.Property(x => x.HoraFin)
                .HasColumnName("horaFin")
                .IsRequired();
        }
    }
}
