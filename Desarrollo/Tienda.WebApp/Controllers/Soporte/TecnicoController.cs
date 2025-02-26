﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tienda.Soporte.Domain.Persistence;
using Tienda.Soporte.Domain.Model.Soporte;
using Tienda.Soporte.Domain.Persistence.Repository;
using Tienda.WebApp.ViewModel;
using System;
using Tienda.WebApp.ViewModel.Soporte;

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

        [HttpPost]
        [Route("insertar-horario")]
        public async Task<IActionResult> InsertarHorario([FromBody] TecnicoHorarioViewModel tecnicoHorarioViewModel)
        {
            TecnicoHorario tecnicoHorario = new TecnicoHorario(tecnicoHorarioViewModel.Dia, tecnicoHorarioViewModel.HoraInicio, 
                tecnicoHorarioViewModel.HoraFin);
            await _tecnicoRepository.InsertHorario(tecnicoHorario, tecnicoHorarioViewModel.TecnicoID);
            await _unitOfWork.Commit();
            return Ok("Success");
        }
    }
}