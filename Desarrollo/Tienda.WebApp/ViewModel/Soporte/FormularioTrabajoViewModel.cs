using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tienda.Soporte.Domain.Model.Soporte;

namespace Tienda.WebApp.ViewModel.Soporte
{
    public class FormularioTrabajoViewModel
    {
        public Guid Id { get; set; }
        public string Comentario { get; set; }
        public OrdenServicio OrdenServicio { get; set; }
        public bool Satisfecho { get; set; }
    }
}
