using CursoDesignPatterns.Investimentos;

namespace CursoDesignPatterns.ServidorAplicacaoBancaria
{
    public enum FormatoResposta
    {
        XML,
        CSV,
        PORCENTO,
        DEFAULT
    }

    public interface IRespostaRequisicao
    {
        public IRespostaRequisicao Proxima { get; set; }

        public string Formatar(ContaBancaria conta, FormatoResposta formato);
    }
}
