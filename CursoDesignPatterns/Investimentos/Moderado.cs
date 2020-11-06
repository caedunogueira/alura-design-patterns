using System;

namespace CursoDesignPatterns.Investimentos
{
    public class Moderado : IInvestimento
    {
        public int Ganhos { get; }

        public Moderado() => Ganhos = new Random().Next(51);

        public Moderado(int porcentagemGanhos) => Ganhos = porcentagemGanhos;

        public decimal CalcularLucro(ContaBancaria conta) => conta.Saldo * ObterPorcentagemLucro();

        private decimal ObterPorcentagemLucro() => (Ganhos >= 51) ? 0.007m : 0.025m;
    }
}
