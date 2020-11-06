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
    public class CitaRepository : ICitaRepository
    {
        private readonly SoporteDomainDBContext _context;

        public CitaRepository(SoporteDomainDBContext context)
        {
            _context = context;
        }

        public async Task<Cita> GetCitaById(Guid id)
        {
            return await _context.Citas.Where(c => c.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IList<Cita>> GetCitas()
        {
            return await _context.Citas.ToListAsync();
        }

        public async Task Insert(Cita cita)
        {
            OrdenServicio ordenServicio = await _context.OrdenesServicios.Where(i => i.Id == cita.OrdenServicio.Id).FirstOrDefaultAsync();
            cita.OrdenServicio = ordenServicio;
            await _context.Citas.AddAsync(cita);
            
            foreach (Tecnico tecnico in cita.Tecnicos)
            {
                List<CitaTecnico> citaTecnicos = await _context.CitaTecnicos.Where(c =>
                    c.Tecnico.Id.Equals(tecnico.Id)
                    && c.Cita.FechaTrabajo.Equals(cita.FechaTrabajo)).ToListAsync();
                if (citaTecnicos.Count > 0) { throw new Exception(String.Format("El tecnico {0} {1} ya tiene una cita el {2}", 
                    tecnico.Nombre, tecnico.Apellido, cita.FechaRegistro)); }

                Tecnico tecnicoTemp = await _context.Tecnicos.Where(p => p.Id == tecnico.Id).FirstAsync();
                CitaTecnico citaTecnico = new CitaTecnico(cita, tecnicoTemp);
                await _context.CitaTecnicos.AddAsync(citaTecnico);
            }
        }
    }
}
