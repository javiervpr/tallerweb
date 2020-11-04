using System;
using System.Collections.Generic;
using System.Text;
using Tienda.SharedKernel.Core;

namespace Tienda.Soporte.Domain.Model.Soporte
{
    public class Producto: Entity
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public string Descripcion { get; set; }

        public Producto(string nombre, string categoria, string descripcion)
        {
            Nombre = nombre;
            Categoria = categoria;
            Descripcion = descripcion;
        }

        protected Producto () { }
    }
}
