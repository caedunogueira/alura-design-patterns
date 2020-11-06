using DesignPatterns2.Cap5;
using System;

namespace DesignPatterns2.Cap4
{
    public class RaizQuadrada : IExpressao
    {
        public IExpressao Valor { get; }

        public RaizQuadrada(IExpressao expressao) => Valor = expressao;

        public void Aceita(IVisitor impressora) => impressora.ImprimeRaizQuadrada(this);

        public int Avalia() => int.Parse(Math.Sqrt(Valor.Avalia()).ToString());
    }
}
