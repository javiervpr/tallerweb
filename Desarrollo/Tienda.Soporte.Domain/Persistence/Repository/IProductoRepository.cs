using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tienda.Soporte.Domain.Model.Soporte;

namespace Tienda.Soporte.Domain.Persistence.Repository
{
    public interface IProductoRepository
    {
        Task Insert(Producto ordenEntrega);
        Task<Producto> GetOrdenEntregaById(Guid id);
    }
}
