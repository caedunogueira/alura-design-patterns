using DesignPatterns2.Cap5;

namespace DesignPatterns2.Cap4
{
    public interface IExpressao
    {
        public int Avalia();

        public void Aceita(IVisitor impressora);
    }
}
