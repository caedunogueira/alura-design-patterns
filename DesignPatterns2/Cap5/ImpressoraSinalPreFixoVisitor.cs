using DesignPatterns2.Cap4;
using System;

namespace DesignPatterns2.Cap5
{
    public class ImpressoraSinalPreFixoVisitor : IVisitor
    {
        public void ImprimeDivisao(Divisao divisao)
        {
            Console.Write("(");
            Console.Write("/");
            Console.Write(" ");
            divisao.Esquerda.Aceita(this);
            Console.Write(" ");
            divisao.Direita.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeMultiplicacao(Multiplicacao multiplicacao)
        {
            Console.Write("(");
            Console.Write("*");
            Console.Write(" ");
            multiplicacao.Esquerda.Aceita(this);
            Console.Write(" ");
            multiplicacao.Direita.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeNumero(Numero numero) => Console.Write(numero.Valor);

        public void ImprimeRaizQuadrada(RaizQuadrada raizQuadrada)
        {
            Console.Write("SQRT -> ");
            raizQuadrada.Valor.Aceita(this);
        }

        public void ImprimeSoma(Soma soma)
        {
            Console.Write("(");
            Console.Write("+");
            Console.Write(" ");
            soma.Esquerda.Aceita(this);
            Console.Write(" ");
            soma.Direita.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeSubtracao(Subtracao subtracao)
        {
            Console.Write("(");
            Console.Write("-");
            Console.Write(" ");
            subtracao.Esquerda.Aceita(this);
            Console.Write(" ");
            subtracao.Direita.Aceita(this);
            Console.Write(")");
        }
    }
}
