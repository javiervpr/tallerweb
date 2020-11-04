using System;
using System.Collections.Generic;
using System.Text;
using Tienda.SharedKernel.Core;

namespace Tienda.Soporte.Domain.Model.Soporte
{
    public class CitaTecnico: Entity
    {
        public Guid Id { get; set; }
        public Cita Cita { get; set; }
        public Tecnico Tecnico { get; set; }

        public CitaTecnico(Cita cita, Tecnico tecnico)
        {
            Id = Guid.NewGuid();
            Cita = cita;
            Tecnico = tecnico;
        }

        protected CitaTecnico() { }
    }
}
