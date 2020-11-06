using System;
using System.Collections.Generic;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var criador = new NotaFiscalBuilder(new List<IAcaoAposGerarNota> 
            { 
                new EnviadorDeEmail(),
                new NotaFiscalDao(),
                new Multiplicador(fator: 3)
            });

            criador
                .ParaEmpresa("Caelum Ensino e Inovação")
                .ComCnpj("23.456.789/0001-12")
                .Com(new ItemDaNota("item 1", 100))
                .Com(new ItemDaNota("item 2", 200))
                .ComObservacoes("uma obs qualquer");

            var nf = criador.Constroi();
            Console.WriteLine(nf.ValorBruto);
            Console.WriteLine(nf.Impostos);
            Console.WriteLine($"{nf.DataDeEmissao:dd/MM/yyyy}");

            Console.ReadKey();
        }
    }
}
