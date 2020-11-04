using System;
using System.Collections.Generic;
using System.Text;
using Tienda.SharedKernel.Core;
using Tienda.SharedKernel.ValueObjects;
using Tienda.Soporte.Domain.ValueObjects;

namespace Tienda.Soporte.Domain.Model.Soporte
{
    public class Tecnico : Entity
    {
        public Guid Id { get; private set; }
        public PersonNameValue Nombre { get; set; }
        public PersonNameValue Apellido { get; set; }
        public EspecialidadTecnicoValue Especialidad { get; set; }


        public Tecnico(string nombre, string apellido, string especialidad)
        {
            Id = Guid.NewGuid();
            Nombre = nombre;
            Apellido = apellido;
            Especialidad = especialidad;
        }

        public Tecnico(Guid id, string nombre, string apellido, string especialidad)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Especialidad = especialidad;
        }

        protected Tecnico() { }

        public IList<TecnicoHorario> GetHorarios()
        {
            return null;
        }
    }
}
