using System;
using System.Collections.Generic;
using System.Text;

namespace Tienda.Soporte.Domain.Model.Soporte
{
    public class OrdenServicioProducto
    {
        public Guid Id { get; set; }
        public OrdenServicio OrdenServicio { get; set; }
        public Producto Producto { get; set; }

        public OrdenServicioProducto(OrdenServicio ordenServicio, Producto producto)
        {
            Id = Guid.NewGuid();
            OrdenServicio = ordenServicio;
            Producto = producto;
        }

        protected OrdenServicioProducto() { }
    }
}
