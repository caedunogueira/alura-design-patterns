using CursoDesignPatterns.Investimentos;
using System.Text.Json;

namespace CursoDesignPatterns.ServidorAplicacaoBancaria
{
    public class RespostaDefault : IRespostaRequisicao
    {
        public IRespostaRequisicao Proxima { get; set;  }

        public string Formatar(ContaBancaria conta, FormatoResposta formato) => JsonSerializer.Serialize(conta);
    }
}
