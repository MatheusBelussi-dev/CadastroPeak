namespace PeakInvest.Domain.Entities
{
    public class Consulta
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }

        private Consulta() { } 

        public Consulta(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
} 