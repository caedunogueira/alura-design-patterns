using System;

namespace CursoDesignPatterns.Investimentos
{
    public class Arrojado : IInvestimento
    {
        public int Ganhos { get; }

        public Arrojado() => Ganhos = new Random().Next(101);

        public Arrojado(int porcentagemGanhos) => Ganhos = porcentagemGanhos;

        public decimal CalcularLucro(ContaBancaria conta) => conta.Saldo * ObterPorcentagemLucro();

        private decimal ObterPorcentagemLucro()
        {
            if (Ganhos <= 20)
                return 0.05m;

            if (Ganhos <= 30)
                return 0.03m;

            return 0.006m;
        }
    }
}
