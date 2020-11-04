using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tienda.Soporte.Domain.Model;
using Tienda.Soporte.Domain.Model.Soporte;

namespace Tienda.Soporte.Infraestructura.Persistence.Repository
{
    public interface IOrdenServicioRepository
    {
        Task Insert(OrdenServicio ordenEntrega);
        Task<OrdenServicio> GetOrdenServicioById(Guid id);

        Task InsertFormularioTrabajo(FormularioTrabajo formulario);
    }
}
