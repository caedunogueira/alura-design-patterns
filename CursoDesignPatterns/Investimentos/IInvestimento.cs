namespace CursoDesignPatterns.Investimentos
{
    public interface IInvestimento
    {
        public int Ganhos { get; }
        public decimal CalcularLucro(ContaBancaria conta);
    }
}
