using PeakInvest.Domain.Entities;
using PeakInvest.Domain.Interfaces;

namespace PeakInvest.Infrastructure.Repositories
{
    public class CalculoRepository : ICalculoRepository
    {
        public CalculoParcelas CalcularValorTotal(int quantidadeParcelas, decimal valorParcela)
        {
            return new CalculoParcelas((short)quantidadeParcelas, valorParcela);
        }
    }
} 