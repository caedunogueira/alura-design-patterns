using System;

namespace CursoDesignPatterns
{
    public class EmAprovacao : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento) => orcamento.AplicaDescontoDe(5);

        public void Aprova(Orcamento orcamento) => orcamento.EstadoAtual = new Aprovado();

        public void Finaliza(Orcamento orcamento) => throw new Exception("Orçamento em aprovação não pode ir para finalizado direto."); 

        public void Reprova(Orcamento orcamento) => orcamento.EstadoAtual = new Reprovado();
    }
}
