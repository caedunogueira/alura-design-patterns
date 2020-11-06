using CursoDesignPatterns.Investimentos;
using System.Collections.Generic;
using System.Linq;

namespace CursoDesignPatterns.ContasFraudulentas
{
    public class FraudeComSaldoMenorQue100Reais : Fraude
    {
        public FraudeComSaldoMenorQue100Reais(Fraude outroFiltro = null) : base(outroFiltro) { }

        public override IReadOnlyCollection<ContaBancaria> Identificar(IReadOnlyCollection<ContaBancaria> contas)
        {
            var contasFraudadas = contas.Where(c => c.PossuiSaldoMenorQue100()).ToHashSet();

            contasFraudadas.UnionWith(AplicarOutraIdentificacao(contas) ?? new HashSet<ContaBancaria>());

            return contasFraudadas;
        }
    }
}
