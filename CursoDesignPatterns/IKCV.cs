using System.Linq;

namespace CursoDesignPatterns
{
    public class IKCV : TemplateDeImpostoCondicional
    {
        public IKCV(Imposto outroImposto = null) : base(outroImposto) { }

        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento) =>
            orcamento.Valor > 500 && orcamento.Itens.Any(i => i.Valor > 100);

        protected override double MaximaTaxacao(Orcamento orcamento) => orcamento.Valor * 0.10 + CalculoOutroImposto(orcamento);

        protected override double MinimaTaxacao(Orcamento orcamento) => orcamento.Valor * 0.06 + CalculoOutroImposto(orcamento);
    }
}
