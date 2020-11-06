using CursoDesignPatterns.Investimentos;
using System.Text.Json;

namespace CursoDesignPatterns.ServidorAplicacaoBancaria
{
    public class RespostaPorCento : IRespostaRequisicao
    {
        public IRespostaRequisicao Proxima { get; set;  }

        public RespostaPorCento() { }

        public RespostaPorCento(IRespostaRequisicao proxima) => Proxima = proxima;

        public string Formatar(ContaBancaria conta, FormatoResposta formato)
        {
            //if (formato != FormatoResposta.PORCENTO)
            //    return Proxima.Formatar(conta, formato);

            //return $"{conta.Titular}%{conta.Saldo:#,##0.00}";

            if (formato != FormatoResposta.PORCENTO)
                return JsonSerializer.Serialize(conta);

            return $"{conta.Titular}%{conta.Saldo:#,##0.00}";
        }
    }
}
