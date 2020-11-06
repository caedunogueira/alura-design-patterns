using CursoDesignPatterns.Investimentos;
using System.Collections.Generic;
using System.Linq;

namespace CursoDesignPatterns.ContasFraudulentas
{
    public class FraudeDataAberturaNoMesCorrente : Fraude
    {
        public FraudeDataAberturaNoMesCorrente(Fraude outroFiltro = null) : base(outroFiltro) { }

        public override IReadOnlyCollection<ContaBancaria> Identificar(IReadOnlyCollection<ContaBancaria> contas)
        {
            var contasFraudadas = contas.Where(c => c.AberturaNoMesCorrente()).ToHashSet();

            contasFraudadas.UnionWith(AplicarOutraIdentificacao(contas) ?? new HashSet<ContaBancaria>());

            return contasFraudadas;
        }
    }
}
