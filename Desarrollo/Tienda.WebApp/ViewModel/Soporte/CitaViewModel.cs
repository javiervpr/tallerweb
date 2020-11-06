using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tienda.Soporte.Domain.Model.Soporte;

namespace Tienda.WebApp.ViewModel.Soporte
{
    public class CitaViewModel
    {
        public Guid Id { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaTrabajo { get; set; }
        public DateTime? FechaConfirmacion { get; set; }
        public DateTime? FechaFinalizacion { get; set; }
        public DateTime? FechaAnulacion { get; set; }
        public string Direccion { get; set; }
        public CitaEstado Estado { get; set; }
        public List<TecnicoViewModel> Tecnicos { get; set; }
        public List<string> TecnicosPK { get; set; }
        public OrdenServicio OrdenServicio { get; set; }

        public List<Tecnico> getListTecnicos()
        {
            List<Tecnico> listTecnicos = new List<Tecnico>();
            foreach(string tecnicoPK in TecnicosPK)
            {
                listTecnicos.Add(new Tecnico(Guid.Parse(tecnicoPK),"   ","   ","   "));
            }
            return listTecnicos;
        }        
    }
}
