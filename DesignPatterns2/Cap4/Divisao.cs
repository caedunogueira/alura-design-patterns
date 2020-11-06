using DesignPatterns2.Cap5;

namespace DesignPatterns2.Cap4
{
    public class Divisao : IExpressao
    {
        public IExpressao Esquerda { get; }
        public IExpressao Direita { get; }

        public Divisao(IExpressao esquerda, IExpressao direita)
        {
            Esquerda = esquerda;
            Direita = direita;
        }

        public void Aceita(IVisitor impressora) => impressora.ImprimeDivisao(this);

        public int Avalia() => Esquerda.Avalia() / Direita.Avalia();
    }
}
