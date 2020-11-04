using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tienda.Soporte.Domain.Model;
using Tienda.Soporte.Domain.Model.Soporte;
using Tienda.Soporte.Domain.Persistence;
using Tienda.Soporte.Infraestructura.Persistence.Repository;
using Tienda.WebApp.ViewModel.Soporte;

namespace Tienda.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdenServicioController : ControllerBase
    {
        private readonly IOrdenServicioRepository _ordenServicioRepository;
        private readonly IUnitOfWork _unitOfWork;

        public OrdenServicioController(IOrdenServicioRepository ordenServicioRepository,
            IUnitOfWork unitOfWork)
        {
            _ordenServicioRepository = ordenServicioRepository;
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        [Route("insertar")]
        public async Task<IActionResult> Insertar([FromBody] OrdenServicioViewModel ordenServicioViewModel)
        {
            OrdenServicio ordenServicio = 
                new OrdenServicio(ordenServicioViewModel.Precio,ordenServicioViewModel.TipoServicio,
                ordenServicioViewModel.NombreCliente,ordenServicioViewModel.ApellidoCliente, ordenServicioViewModel.Productos);

            await _ordenServicioRepository.Insert(ordenServicio);
            await _unitOfWork.Commit();
            return Ok("Success");
        }

        [HttpPost]
        [Route("insertar-formulario-trabajo")]
        public async Task<IActionResult> CrearFormularioTrabajo([FromBody] FormularioTrabajoViewModel formulario)
        {
            FormularioTrabajo formularioTrabajo = new FormularioTrabajo(formulario.Comentario, formulario.OrdenServicio, formulario.Satisfecho);
            await _ordenServicioRepository.InsertFormularioTrabajo(formularioTrabajo);
            await _unitOfWork.Commit();
            return Ok("Success");
        }
    }
}