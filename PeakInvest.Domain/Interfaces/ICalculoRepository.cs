using PeakInvest.Domain.Entities;

namespace PeakInvest.Domain.Interfaces
{
    public interface ICalculoRepository
    {
        CalculoParcelas CalcularValorTotal(int quantidadeParcelas, decimal valorParcela);
    }
} 