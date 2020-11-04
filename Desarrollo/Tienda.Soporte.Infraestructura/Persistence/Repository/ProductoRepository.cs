using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.Soporte.Domain.Model.Soporte;
using Tienda.Soporte.Domain.Persistence.Repository;

namespace Tienda.Soporte.Infraestructura.Persistence.Repository
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly SoporteDomainDBContext _context;

        public ProductoRepository(SoporteDomainDBContext context)
        {
            _context = context;
        }

        public async Task<Producto> GetOrdenEntregaById(Guid id)
        {
            return await _context.Productos.Where(x => x.Id == id).FirstOrDefaultAsync(); 
        }

        public async Task Insert(Producto producto)
        {
            await _context.Productos.AddAsync(producto);
        }
    }
}
