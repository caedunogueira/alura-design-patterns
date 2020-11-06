namespace CursoDesignPatterns
{
    public interface IDesconto
    {
        IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento);
    }
}
