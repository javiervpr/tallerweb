using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tienda.Soporte.Domain.Model.Soporte;

namespace Tienda.Soporte.Domain.Persistence.Repository
{
    public interface ICitaRepository
    {
        Task Insert(Cita cita);
        Task<Cita> GetCitaById(Guid id);
        Task<IList<Cita>> GetCitas();
    }
}
