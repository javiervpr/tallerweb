using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tienda.Soporte.Domain.Persistence;
using Tienda.Soporte.Domain.Model.Soporte;
using Tienda.Soporte.Domain.Persistence.Repository;
using Tienda.WebApp.ViewModel;

namespace Tienda.WebApp.Controllers.Soporte
{
    [Route("api/[controller]")]
    [ApiController]
    public class TecnicoController : ControllerBase
    {
        private readonly ITecnicoRepository _tecnicoRepository;
        private readonly IUnitOfWork _unitOfWork;

        public TecnicoController(ITecnicoRepository tecnicoRepository, IUnitOfWork unitOfWork)
        {
            _tecnicoRepository = tecnicoRepository;
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        [Route("insertar")]
        public async Task<IActionResult> Insertar([FromBody] TecnicoViewModel tecnicoViewModel)
        {
            Tecnico tecnico = new Tecnico(tecnicoViewModel.Nombre, tecnicoViewModel.Apellido, tecnicoViewModel.Especialidad);
            await _tecnicoRepository.Insert(tecnico);
            await _unitOfWork.Commit();
            return Ok("Success");

        }
    }
}