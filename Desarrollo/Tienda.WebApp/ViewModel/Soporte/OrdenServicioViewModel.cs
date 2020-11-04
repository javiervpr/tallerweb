using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tienda.Soporte.Domain.Model.Soporte;

namespace Tienda.WebApp.ViewModel.Soporte
{
    public class OrdenServicioViewModel
    {
        public string Id { get; set; }
        public double Precio { get; set; }
        public TipoServicio TipoServicio { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public List<Producto> Productos { get; set; }
    }
}
