using System;

namespace DesignPatterns2.Cap6
{
    public class MensagemAdministrativa : IMensagem
    {
        private readonly string nome;

        public IEnviador Enviador { get; set; }

        public MensagemAdministrativa(string nome) => this.nome = nome;

        public void Envia() => Enviador.Envia(this);

        public string Formata() => $"Enviando mensagem para o administrador {nome}";
    }
}
