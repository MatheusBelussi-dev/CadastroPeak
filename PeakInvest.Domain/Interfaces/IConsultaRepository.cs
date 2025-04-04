using PeakInvest.Domain.Entities;

namespace PeakInvest.Domain.Interfaces
{
    public interface IConsultaRepository
    {
        Consulta ObterPorId(int id);
    }
} 