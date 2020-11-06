using DesignPatterns2.Cap5;

namespace DesignPatterns2.Cap4
{
    public class Multiplicacao : IExpressao
    {
        public IExpressao Esquerda { get; }
        public IExpressao Direita { get; }

        public Multiplicacao(IExpressao esquerda, IExpressao direita)
        {
            Esquerda = esquerda;
            Direita = direita;
        }

        public void Aceita(IVisitor impressora) => impressora.ImprimeMultiplicacao(this);

        public int Avalia() => Esquerda.Avalia() * Direita.Avalia();
    }
}
