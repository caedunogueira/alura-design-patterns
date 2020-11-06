using DesignPatterns2.Cap5;

namespace DesignPatterns2.Cap4
{
    public class Soma : IExpressao
    {
        public IExpressao Esquerda { get; }
        public IExpressao Direita { get; }

        public Soma(IExpressao esquerda, IExpressao direita)
        {
            Esquerda = esquerda;
            Direita = direita;
        }

        public int Avalia() => Esquerda.Avalia() + Direita.Avalia();

        public void Aceita(IVisitor impressora) => impressora.ImprimeSoma(this);
    }
}
