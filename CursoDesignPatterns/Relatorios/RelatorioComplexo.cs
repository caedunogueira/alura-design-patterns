using CursoDesignPatterns.Investimentos;
using System;
using System.Collections.Generic;

namespace CursoDesignPatterns.Relatorios
{
    public class RelatorioComplexo : Relatorio
    {
        protected override void ImprimirCabecalho(Banco banco)
        {
            Console.WriteLine($"************************************************************************************");
            Console.WriteLine(banco.Nome.ToUpper());
            Console.WriteLine($"Endereço: {banco.Endereco}");
            Console.WriteLine($"Telefone: {banco.Telefone}");
            Console.WriteLine($"************************************************************************************");
        }

        protected override void ImprimirCorpo(IEnumerable<ContaBancaria> contas)
        {
            foreach (var conta in contas)
            {
                Console.WriteLine($"Conta do titular {conta.Titular}");
                Console.WriteLine($"Agência: {conta.Agencia}");
                Console.WriteLine($"Número: {conta.Numero}");
                Console.WriteLine($"Saldo: R$ {conta.Saldo:#,##0.00}");
                Console.WriteLine();
            }
        }

        protected override void ImprimirRodape(Banco banco) =>
            Console.WriteLine($"E-mail para contato: {banco.Email}                      -                       {DateTime.Today:dd/MM/yyyy}");
    }
}
