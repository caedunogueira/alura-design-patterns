using CursoDesignPatterns.Investimentos;
using System.Collections.Generic;
using System.Linq;

namespace CursoDesignPatterns.ContasFraudulentas
{
    public class FraudeComSaldoMaiorQue500MilReais : Fraude
    {
        public FraudeComSaldoMaiorQue500MilReais(Fraude outroFiltro = null) : base(outroFiltro) { }

        public override IReadOnlyCollection<ContaBancaria> Identificar(IReadOnlyCollection<ContaBancaria> contas)
        {
            var contasFraudadas = contas.Where(c => c.PossuiSaldoMaiorQue500Mil()).ToHashSet();

            contasFraudadas.UnionWith(AplicarOutraIdentificacao(contas) ?? new HashSet<ContaBancaria>());

            return contasFraudadas;
        }
    }
}
