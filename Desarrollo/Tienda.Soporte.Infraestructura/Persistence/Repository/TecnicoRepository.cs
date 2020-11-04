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
    public class TecnicoRepository : ITecnicoRepository
    {
        private readonly SoporteDomainDBContext _context;

        public TecnicoRepository(SoporteDomainDBContext context)
        {
            _context = context;
        }

        public async Task<Tecnico> GetTecnicoById(Guid id)
        {
            return await _context.Tecnicos.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task Insert(Tecnico tecnico)
        {
            await _context.AddAsync(tecnico);
        }
    }
}
