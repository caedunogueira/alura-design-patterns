namespace CursoDesignPatterns
{
    public class ISS : Imposto
    {
        public ISS(Imposto outroImposto = null) : base(outroImposto) { }

        public override double Calcula(Orcamento orcamento) => orcamento.Valor * 0.06 + CalculoOutroImposto(orcamento);
    }
}
