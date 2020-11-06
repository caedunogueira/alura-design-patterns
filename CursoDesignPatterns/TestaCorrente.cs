using System;

namespace CursoDesignPatterns
{
    public class TestaCorrente
    {
        public void TestaDescontoDeOrcamentoComMaisDe5Itens()
        {
            var calculador = new CalculadorDeDescontos();
            var orcamento = new Orcamento(1500);

            orcamento.AdicionaItem(new Item("CANETA", 250));
            orcamento.AdicionaItem(new Item("LAPIS", 250));
            orcamento.AdicionaItem(new Item("GELADEIRA", 250));
            orcamento.AdicionaItem(new Item("FOGAO", 250));
            orcamento.AdicionaItem(new Item("MICROONDAS", 250));
            orcamento.AdicionaItem(new Item("XBOX", 250));

            var desconto = calculador.Calcula(orcamento);

            Console.WriteLine($"Desconto (10%) para mais de 5 itens no orçamento de R$ {orcamento.Valor:#,##0.00}: desconto de R$ {desconto:#,##0.00}");
        }

        public void TesteDescontoDeOrcamentoDeMaisDeQuinhentosReais()
        {
            var calculador = new CalculadorDeDescontos();
            var orcamento = new Orcamento(800);

            orcamento.AdicionaItem(new Item("GELADEIRA", 500));
            orcamento.AdicionaItem(new Item("MICROONDAS", 300));

            var desconto = calculador.Calcula(orcamento);

            Console.WriteLine($"Desconto (7%) para orçamento acima de R$ 500,00, no valor de R$ {orcamento.Valor:#,##0.00}: desconto de R$ {desconto:#,##0.00}");
        }

        public void TesteDescontoDeOrcamentoParaVendaCasada()
        {
            var calculador = new CalculadorDeDescontos();
            var orcamento = new Orcamento(355);

            orcamento.AdicionaItem(new Item("CANETA", 50));
            orcamento.AdicionaItem(new Item("LAPIS", 5));
            orcamento.AdicionaItem(new Item("XBOX", 300));

            var desconto = calculador.Calcula(orcamento);

            Console.WriteLine($"Desconto (5%) para venda casada de lapis e caneta no orçamento de R$ {orcamento.Valor:#,##0.00}: desconto de R$ {desconto:#,##0.00}");
        }

        public void TesteDescontoDeOrcamentoSemQueHajaDesconto()
        {
            var calculador = new CalculadorDeDescontos();
            var orcamento = new Orcamento(175);

            orcamento.AdicionaItem(new Item("CANETA", 5));
            orcamento.AdicionaItem(new Item("FOGAO", 150));
            orcamento.AdicionaItem(new Item("MICROONDAS", 120));


            var desconto = calculador.Calcula(orcamento);

            Console.WriteLine($"Sem desconto para orçamento de R$ {orcamento.Valor:#,##0.00}: desconto de R$ {desconto:#,##0.00}");
        }
    }
}
