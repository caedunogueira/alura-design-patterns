using CursoDesignPatterns.Investimentos;
using System;
using System.Collections.Generic;

namespace CursoDesignPatterns.Relatorios
{
    public class RelatorioSimples : Relatorio
    {
        protected override void ImprimirCabecalho(Banco banco) =>
            Console.WriteLine($"****************************** {banco.Nome.ToUpper()} ******************************");

        protected override void ImprimirCorpo(IEnumerable<ContaBancaria> contas)
        {
            foreach (var conta in contas)
            {
                Console.WriteLine($"Conta do titular {conta.Titular}");
                Console.WriteLine($"Saldo: R$ {conta.Saldo:#,##0.00}");
                Console.WriteLine();
            }
        }

        protected override void ImprimirRodape(Banco banco) => 
            Console.WriteLine($"Telefone para contato: {banco.Telefone}");
    }
}
