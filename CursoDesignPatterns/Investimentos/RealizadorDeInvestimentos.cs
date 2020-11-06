using System;

namespace CursoDesignPatterns.Investimentos
{
    public class RealizadorDeInvestimentos
    {
        public void Investir(ContaBancaria conta, IInvestimento investimento)
        {
            var saldoOriginal = conta.Saldo;
            var lucroBruto = investimento.CalcularLucro(conta);
            var lucroLiquido = lucroBruto - (25m / 100m);

            conta.Depositar(lucroLiquido);

            Console.WriteLine($"Para um saldo de R$ {saldoOriginal:#,##0.00}, em um investimento {investimento.GetType().Name} " +
                $"com porcentagens de ganho em até {investimento.Ganhos}%, o lucro foi de R$ {lucroBruto:#,##0.00}. " + 
                $"O novo saldo é {conta.Saldo:#,##0.00} (já deduzido os impostos).");
        }
    }
}
