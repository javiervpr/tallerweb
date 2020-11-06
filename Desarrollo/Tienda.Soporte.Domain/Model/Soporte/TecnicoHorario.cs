using System;
using System.Collections.Generic;
using System.Text;
using Tienda.SharedKernel.Core;
using Tienda.SharedKernel.Model;

namespace Tienda.Soporte.Domain.Model.Soporte
{
    public class TecnicoHorario: Entity
    {
        public Guid Id { get; set; }
        public Dia Dia { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFin { get; set; }
        public Tecnico Tecnico { get; set; }


        public TecnicoHorario(Dia dia, DateTime horaInicio, DateTime horaFin, Tecnico tecnico = null)
        {
            CheckRule(new NotNullRule<DateTime>(HoraInicio));
            CheckRule(new NotNullRule<DateTime>(HoraFin));

            Id = Guid.NewGuid();
            Dia = dia;
            HoraInicio = horaInicio;
            HoraFin = horaFin;
            Tecnico = tecnico;
        }

        protected TecnicoHorario () { }
    }
}
