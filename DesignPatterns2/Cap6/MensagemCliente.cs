using System;

namespace DesignPatterns2.Cap6
{
    public class MensagemCliente : IMensagem
    {
        private readonly string nome;

        public MensagemCliente(string nome) => this.nome = nome;

        public IEnviador Enviador { get; set; }

        public void Envia() => Enviador.Envia(this);

        public string Formata() => $"Enviando mensagem para o cliente {nome}";
    }
}
