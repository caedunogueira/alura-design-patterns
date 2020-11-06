using DesignPatterns2.Cap5;

namespace DesignPatterns2.Cap4
{
    public class Numero : IExpressao
    {
        public int Valor { get; }

        public Numero(int numero) => Valor = numero;

        public int Avalia() => Valor;

        public void Aceita(IVisitor impressora) => impressora.ImprimeNumero(this);
    }
}
