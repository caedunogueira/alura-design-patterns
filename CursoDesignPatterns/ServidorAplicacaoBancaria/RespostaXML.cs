using CursoDesignPatterns.Investimentos;

namespace CursoDesignPatterns.ServidorAplicacaoBancaria
{
    public class RespostaXML : IRespostaRequisicao
    {
        public IRespostaRequisicao Proxima { get; set;  }

        public RespostaXML() { }

        public RespostaXML(IRespostaRequisicao proxima) => Proxima = proxima;

        public string Formatar(ContaBancaria conta, FormatoResposta formato)
        {
            if (formato != FormatoResposta.XML)
                return Proxima.Formatar(conta, formato);

            return $"<conta><titular>{conta.Titular}</titular><saldo>{conta.Saldo:#,##0.00}</saldo></conta>";
        }
    }
}
