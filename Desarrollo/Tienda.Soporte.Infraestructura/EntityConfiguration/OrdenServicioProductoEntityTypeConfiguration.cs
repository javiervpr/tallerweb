using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Tienda.Soporte.Domain.Model.Soporte;

namespace Tienda.Soporte.Infraestructura.EntityConfiguration
{
    public class OrdenServicioProductoEntityTypeConfiguration : IEntityTypeConfiguration<OrdenServicioProducto>
    {  
        public void Configure(EntityTypeBuilder<OrdenServicioProducto> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
