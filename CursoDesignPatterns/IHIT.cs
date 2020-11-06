using System.Linq;

namespace CursoDesignPatterns
{
    public class IHIT : TemplateDeImpostoCondicional
    {
        public IHIT(Imposto outroImposto = null) : base(outroImposto) { }

        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento) =>
            orcamento.Itens.Count != orcamento.Itens
                                        .Select(i => i.Nome)
                                        .Distinct()
                                        .Count();

        protected override double MaximaTaxacao(Orcamento orcamento) => (orcamento.Valor * 0.13) + 100 + CalculoOutroImposto(orcamento);

        protected override double MinimaTaxacao(Orcamento orcamento) => (orcamento.Valor * 0.01) * orcamento.Itens.Count + CalculoOutroImposto(orcamento);
    }
}
