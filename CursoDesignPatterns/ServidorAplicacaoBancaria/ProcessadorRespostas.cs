using CursoDesignPatterns.Investimentos;

namespace CursoDesignPatterns.ServidorAplicacaoBancaria
{
    public class ProcessadorRespostas
    {
        public string Processar(ContaBancaria conta, FormatoResposta formato)
        {
            /*
            var respostaCSV = new RespostaCSV();
            var respostaXML = new RespostaXML();
            var respostaPorCento = new RespostaPorCento();
            var respostaDefault = new RespostaDefault();

            respostaCSV.Proxima = respostaXML;
            respostaXML.Proxima = respostaPorCento;
            respostaPorCento.Proxima = respostaDefault;
            */
            var respostaDefault = new RespostaDefault();
            var respostaPorCento = new RespostaPorCento(proxima: respostaDefault);
            var respostaXML = new RespostaPorCento(proxima: respostaPorCento);
            var respostaCSV = new RespostaCSV(proxima: respostaXML);

            return respostaCSV.Formatar(conta, formato);
        }
    }
}
