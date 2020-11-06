namespace CursoDesignPatterns.Investimentos
{
    public class Conservador : IInvestimento
    {
        public int Ganhos => 100;

        public decimal CalcularLucro(ContaBancaria conta) => conta.Saldo * 0.008m;
    }
}
