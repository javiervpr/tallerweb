﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Tienda.Soporte.Domain.Model.Soporte;

namespace Tienda.Soporte.Infraestructura.EntityConfiguration
{
    public class ProductoEntityTypeConfiguration : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nombre)
                .HasColumnName("nombre")
                .IsRequired();
            builder.Property(x => x.Categoria)
                .HasColumnName("categoria")
                .IsRequired();
            builder.Property(x => x.Descripcion)
                .HasColumnName("descripcion")
                .IsRequired();
        }
    }
}
