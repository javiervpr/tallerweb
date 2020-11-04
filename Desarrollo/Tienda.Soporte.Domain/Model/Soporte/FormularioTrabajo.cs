using System;
using System.Collections.Generic;
using System.Text;
using Tienda.SharedKernel.Core;
using Tienda.Soporte.Domain.Model.Soporte;
using Tienda.Soporte.ValueObjects;

namespace Tienda.Soporte.Domain.Model
{
    public class FormularioTrabajo: Entity
    {
        public Guid Id { get; set; }
        public ComentarioClienteValue Comentario { get; set; }
        public OrdenServicio OrdenServicio { get; set; }
        public bool Satisfecho { get; set; }

        public FormularioTrabajo(ComentarioClienteValue comentario, OrdenServicio ordenServicio, bool satisfecho)
        {
            Id = Guid.NewGuid();
            Comentario = comentario;
            OrdenServicio = ordenServicio;
            Satisfecho = satisfecho;
        }

        protected FormularioTrabajo() { }
    }
}
