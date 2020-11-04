using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tienda.WebApp.ViewModel
{
    public class TecnicoViewModel
    {
        public string Id { get; private set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Especialidad { get; set; }
    }
}
