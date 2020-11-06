using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tienda.SharedKernel.Model;
using Tienda.Soporte.Domain.Model.Soporte;

namespace Tienda.WebApp.ViewModel.Soporte
{
    public class TecnicoHorarioViewModel
    {
        public string Id { get; set; }
        public Dia Dia { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFin { get; set; }
        public string TecnicoID { get; set; }
    }
}
