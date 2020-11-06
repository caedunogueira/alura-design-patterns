namespace CursoDesignPatterns
{
    public class ICMS : Imposto
    {
        public ICMS(Imposto outroImposto = null) : base(outroImposto) { }

        public override double Calcula(Orcamento orcamento) => (orcamento.Valor * 0.05) + 50 + CalculoOutroImposto(orcamento);
    }
}
