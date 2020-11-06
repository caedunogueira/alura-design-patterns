namespace CursoDesignPatterns
{
    public class ICCC : Imposto
    {
        public ICCC(Imposto outroImposto = null) : base(outroImposto) { }

        public override double Calcula(Orcamento orcamento)
        {
            if (orcamento.Valor < 1000)
                return orcamento.Valor * 0.05 + CalculoOutroImposto(orcamento);
            
            if (orcamento.Valor >= 1000 && orcamento.Valor <= 3000)
                return orcamento.Valor * 0.07 + CalculoOutroImposto(orcamento);
            
            return (orcamento.Valor * 0.08) + 30 + CalculoOutroImposto(orcamento);
        }
    }
}
