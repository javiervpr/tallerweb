using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using Tienda.SharedKernel.Core;
using Tienda.SharedKernel.ValueObjects.Address;

namespace Tienda.Soporte.Domain.Model.Soporte
{
    public class Cita: Entity
    {
        public Guid Id { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaTrabajo { get; set; }
        public DateTime? FechaConfirmacion { get; set; }
        public DateTime? FechaFinalizacion { get; set; }
        public DateTime? FechaAnulacion { get; set; }
        public AddressValue Direccion { get; set; }
        public CitaEstado Estado { get; set; }
        public OrdenServicio OrdenServicio { get; set; }
        
        private List<Tecnico> _tecnicos;

        public ImmutableList<Tecnico> Tecnicos
        {
            get
            {
                return _tecnicos.ToImmutableList<Tecnico>();
            }
        }


        public Cita(DateTime fechaTrabajo, string direccion, OrdenServicio ordenServicio, List<Tecnico> tecnicos)
        {
            Id = Guid.NewGuid();
            FechaRegistro = DateTime.Now;
            FechaTrabajo = fechaTrabajo;
            Direccion = direccion;
            OrdenServicio = ordenServicio;
            Estado = CitaEstado.Creada;

            _tecnicos = new List<Tecnico>();
            foreach (Tecnico tecnico in tecnicos)
            {
                _tecnicos.Add(tecnico);
            }
        }

        protected Cita() { }
    }
}
