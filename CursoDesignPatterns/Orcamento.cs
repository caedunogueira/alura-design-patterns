using System;
using System.Collections.Generic;

namespace CursoDesignPatterns
{
    public class Orcamento
    {
        private bool _comDesconto = false;

        public double Valor { get; private set; }
        public IList<Item> Itens { get; }
        public IEstadoDeUmOrcamento EstadoAtual { get; set; }

        public Orcamento(double valor)
        {
            Itens = new List<Item>();
            EstadoAtual ??= new EmAprovacao();
            Valor = valor;
        }

        public void AplicaDescontoExtra() => EstadoAtual.AplicaDescontoExtra(this);

        public void AplicaDescontoDe(double porcentagem)
        {
            if (_comDesconto)
                throw new Exception("Este orçamento já recebeu um desconto. Descontos podem ser concedidos somente uma vez.");

            Valor -= Valor * (porcentagem / 100);
            _comDesconto = true;
        }

        public void AdicionaItem(Item item) => Itens.Add(item);

        public void Aprova() => EstadoAtual.Aprova(this);

        public void Reprova() => EstadoAtual.Reprova(this);

        public void Finaliza() => EstadoAtual.Finaliza(this);
    }
}
