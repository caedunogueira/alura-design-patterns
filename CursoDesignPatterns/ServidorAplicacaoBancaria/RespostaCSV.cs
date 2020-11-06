using CursoDesignPatterns.Investimentos;

namespace CursoDesignPatterns.ServidorAplicacaoBancaria
{
    public class RespostaCSV : IRespostaRequisicao
    {
        public IRespostaRequisicao Proxima { get; set; }

        public RespostaCSV() { }

        public RespostaCSV(IRespostaRequisicao proxima) => Proxima = proxima;

        public string Formatar(ContaBancaria conta, FormatoResposta formato)
        {
            if (formato != FormatoResposta.CSV)
                return Proxima.Formatar(conta, formato);

            return $"{conta.Titular};{conta.Saldo:#,##0.00}";
        }
    }
}
