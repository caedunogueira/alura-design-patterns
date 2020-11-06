namespace CursoDesignPatterns
{
    public class ImpostoMuitoAlto : Imposto
    {
        public ImpostoMuitoAlto(Imposto outroImposto = null) : base(outroImposto) { }

        public override double Calcula(Orcamento orcamento) => (orcamento.Valor * 0.20) + CalculoOutroImposto(orcamento);
    }
}
