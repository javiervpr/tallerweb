using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tienda.Soporte.Domain.Model.Soporte;
using Tienda.Soporte.Domain.Persistence;
using Tienda.Soporte.Domain.Persistence.Repository;
using Tienda.WebApp.ViewModel.Soporte;

namespace Tienda.WebApp.Controllers.Soporte
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitaController : ControllerBase
    {
        private readonly ICitaRepository _citaRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CitaController(ICitaRepository citaRepository, IUnitOfWork unitOfWork)
        {
            _citaRepository = citaRepository;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetCitas()
        {
            IList<Cita> citas = await _citaRepository.GetCitas();
            return Ok(citas);
        }
        [HttpPost]
        [Route("insertar")]
        public async Task<IActionResult> Insertar([FromBody] CitaViewModel citaViewModel)
        {

            Cita cita = new Cita(citaViewModel.FechaTrabajo, citaViewModel.Direccion, citaViewModel.OrdenServicio, citaViewModel.getListTecnicos());
            await _citaRepository.Insert(cita);
            await _unitOfWork.Commit();
            return Ok("Success");

        }
    }
}