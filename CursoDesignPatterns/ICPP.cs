namespace CursoDesignPatterns
{
    public class ICPP : TemplateDeImpostoCondicional
    {
        public ICPP(Imposto outroImposto = null) : base(outroImposto) { }

        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento) => orcamento.Valor >= 500;

        protected override double MaximaTaxacao(Orcamento orcamento) => orcamento.Valor * 0.07 + CalculoOutroImposto(orcamento);

        protected override double MinimaTaxacao(Orcamento orcamento) => orcamento.Valor * 0.05 + CalculoOutroImposto(orcamento);
    }
}
