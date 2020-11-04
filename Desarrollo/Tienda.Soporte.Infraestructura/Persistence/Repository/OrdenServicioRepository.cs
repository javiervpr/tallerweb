using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.Soporte.Domain.Model;
using Tienda.Soporte.Domain.Model.Soporte;

namespace Tienda.Soporte.Infraestructura.Persistence.Repository
{
    public class OrdenServicioRepository : IOrdenServicioRepository
    {
        private readonly SoporteDomainDBContext _context;

        public OrdenServicioRepository(SoporteDomainDBContext context)
        {
            _context = context;
        }

        public async Task<OrdenServicio> GetOrdenServicioById(Guid id)
        {
            OrdenServicio obj =
               await _context.OrdenesServicios.Where(o => o.Id == id).FirstOrDefaultAsync();
            return obj;
        }

        public async Task Insert(OrdenServicio ordenServicio)
        {
            await _context.OrdenesServicios.AddAsync(ordenServicio);
            foreach (Producto producto in ordenServicio.Productos)
            {
                Producto productTEMP = await _context.Productos.Where(p => p.Id == producto.Id).FirstAsync();
                OrdenServicioProducto ordenServicioProducto = new OrdenServicioProducto(ordenServicio, productTEMP);
                await _context.OrdenServicioProductos.AddAsync(ordenServicioProducto);
            }

        }

        public async Task InsertFormularioTrabajo(FormularioTrabajo formulario)
        {
            OrdenServicio ordenServicio = await _context.OrdenesServicios.Where(o => o.Id == formulario.OrdenServicio.Id).FirstOrDefaultAsync();
            formulario.OrdenServicio = ordenServicio;
            await _context.FormularioTrabajos.AddAsync(formulario);
        }
    }
}
