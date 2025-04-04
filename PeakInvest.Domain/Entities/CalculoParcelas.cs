using System;

namespace PeakInvest.Domain.Entities
{
    public class CalculoParcelas
    {
        public short QuantidadeParcelas { get; private set; }
        public decimal ValorParcela { get; private set; }
        public decimal ResultadoCalculo { get; private set; }

        public CalculoParcelas(short quantidadeParcelas, decimal valorParcela)
        {
            QuantidadeParcelas = quantidadeParcelas;
            ValorParcela = valorParcela;
            CalcularResultado();
        }

        private void CalcularResultado()
        {
            var valorBase = ValorParcela * QuantidadeParcelas;
            ResultadoCalculo = valorBase * 1.05m; // Adiciona 5%
        }
    }
} 