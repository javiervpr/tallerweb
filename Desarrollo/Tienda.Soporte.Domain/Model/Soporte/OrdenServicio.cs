using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using Tienda.SharedKernel.Core;
using Tienda.SharedKernel.ValueObjects;
using Tienda.Soporte.ValueObjects;

namespace Tienda.Soporte.Domain.Model.Soporte
{
    public class OrdenServicio: Entity
    {
        public Guid Id { get; set; }
        public PrecioServicioValue Precio { get; set; }
        public TipoServicio TipoServicio { get; set; }
        public DateTime FechaRegistro { get; set; }
        public PersonNameValue NombreCliente { get; set; }
        public PersonNameValue ApellidoCliente { get; set; }

        private List<Producto> _productos;

        public ImmutableList<Producto> Productos
        {
            get
            {
                return _productos.ToImmutableList<Producto>();
            }
        }

        public OrdenServicio(double precio, TipoServicio tipoServicio, string nombreCliente, string apellidoCliente,List<Producto> productos)
        {
            Id = Guid.NewGuid();
            Precio = precio;
            TipoServicio = tipoServicio;
            FechaRegistro = DateTime.Now;
            NombreCliente = nombreCliente;
            ApellidoCliente = apellidoCliente;

            _productos = new List<Producto>();
            foreach(Producto producto in productos)
            {
                _productos.Add(producto);
            }
        }   
        protected OrdenServicio() { }
    }
}
