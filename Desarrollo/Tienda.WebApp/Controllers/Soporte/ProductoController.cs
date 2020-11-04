using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tienda.Soporte.Domain.Model.Soporte;
using Tienda.Soporte.Domain.Persistence;
using Tienda.Soporte.Domain.Persistence.Repository;

namespace Tienda.WebApp.Controllers.Soporte
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoRepository _productoRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ProductoController(IProductoRepository productoRepository, IUnitOfWork unitOfWork)
        {
            _productoRepository = productoRepository;
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        [Route("insertar")]
        public async Task<IActionResult> Insertar([FromBody] Producto producto)
        {
            await _productoRepository.Insert(producto);
            await _unitOfWork.Commit();

            return Ok("Success");
        }
        }
}