using Microsoft.AspNetCore.Mvc;
using PeakInvest.Application.Services;
using PeakInvest.Domain.Entities;

namespace PeakInvest.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConsultaController : ControllerBase
    {
        private readonly ConsultaService _consultaService;

        public ConsultaController(ConsultaService consultaService)
        {
            _consultaService = consultaService;
        }

        [HttpGet("{id}")]
        public ActionResult<string> GetNome(int id)
        {
            var consulta = _consultaService.ObterNomePorId(id);
            if (consulta == null)
            {
                return NotFound();
            }

            return Ok(new { nome = consulta.Nome });
        }
    }
} 