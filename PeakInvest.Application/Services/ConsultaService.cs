using PeakInvest.Domain.Entities;
using PeakInvest.Domain.Interfaces;

namespace PeakInvest.Application.Services
{
    public class ConsultaService
    {
        private readonly IConsultaRepository _consultaRepository;

        public ConsultaService(IConsultaRepository consultaRepository)
        {
            _consultaRepository = consultaRepository;
        }

        public Consulta ObterNomePorId(int id)
        {
            return _consultaRepository.ObterPorId(id);
        }
    }
} 