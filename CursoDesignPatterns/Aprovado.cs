using System;

namespace CursoDesignPatterns
{
    public class Aprovado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento) => orcamento.AplicaDescontoDe(2);

        public void Aprova(Orcamento orcamento) => throw new Exception("Orçamento já está em estado de aprovação");

        public void Finaliza(Orcamento orcamento) => orcamento.EstadoAtual = new Finalizado();

        public void Reprova(Orcamento orcamento) => throw new Exception("Orçamento está em aprovação, não pode ser reprovado agora");
    }
}
