using System.Linq;

namespace CursoDesignPatterns
{
    public class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            var vendaCasadaLapisCaneta = orcamento.Itens.Count(i => i.Nome == "LAPIS" || i.Nome == "CANETA") == 2;

            if (vendaCasadaLapisCaneta)
                return orcamento.Valor * 0.05;

            return Proximo.Desconta(orcamento);
        }
    }
}
