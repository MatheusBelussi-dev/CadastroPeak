using Microsoft.AspNetCore.Mvc;
using PeakInvest.Application.Services;
using PeakInvest.Domain.Entities;

namespace PeakInvest.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculoController : ControllerBase
    {
        private readonly CalculoService _calculoService;

        public CalculoController(CalculoService calculoService)
        {
            _calculoService = calculoService;
        }

        [HttpPost]
        public ActionResult<CalculoParcelas> Calcular([FromBody] CalculoRequest request)
        {
            var resultado = _calculoService.CalcularValorTotalAsync(request.QuantidadeParcelas, request.ValorParcela);
            return Ok(resultado);
        }
    }

    public class CalculoRequest
    {
        public int QuantidadeParcelas { get; set; }
        public decimal ValorParcela { get; set; }
    }
} 