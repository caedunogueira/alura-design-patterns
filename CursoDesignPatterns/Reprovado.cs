using System;

namespace CursoDesignPatterns
{
    public class Reprovado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento) => throw new Exception("Orçamentos reprovados nao recebem desconto extra.");

        public void Aprova(Orcamento orcamento) => throw new Exception("Orçamento está em reprovação, não pode ser aprovado agora");

        public void Finaliza(Orcamento orcamento) => orcamento.EstadoAtual = new Finalizado();

        public void Reprova(Orcamento orcamento) => throw new Exception("Orçamento já está em estado de reprovação");
    }
}
