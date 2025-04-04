using PeakInvest.Domain.Entities;
using PeakInvest.Domain.Interfaces;

namespace PeakInvest.Infrastructure.Repositories
{
    public class ConsultaRepository : IConsultaRepository
    {
        private readonly List<KeyValuePair<int, string>> _lista;

        public ConsultaRepository()
        {
            _lista = new List<KeyValuePair<int, string>>();
            _lista.Add(new KeyValuePair<int, string>(1, "João"));
            _lista.Add(new KeyValuePair<int, string>(2, "Maria"));
            _lista.Add(new KeyValuePair<int, string>(3, "Ana"));
        }

        public Consulta ObterPorId(int id)
        {
            var item = _lista.Find(x => x.Key == id);
            if (item.Key == 0)
            {
                return null;
            }

            return new Consulta(item.Key, item.Value);
        }
    }
} 