using System.Threading.Tasks;
using PeakInvest.Domain.Entities;
using PeakInvest.Domain.Interfaces;

namespace PeakInvest.Application.Services
{
    public class CalculoService
    {
        private readonly ICalculoRepository _calculoRepository;

        public CalculoService(ICalculoRepository calculoRepository)
        {
            _calculoRepository = calculoRepository;
        }

        public CalculoParcelas CalcularValorTotalAsync(int quantidadeParcelas, decimal valorParcela)
        {
            return _calculoRepository.CalcularValorTotal(quantidadeParcelas, valorParcela);
        }
    }
} 