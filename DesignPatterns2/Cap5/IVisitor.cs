using DesignPatterns2.Cap4;

namespace DesignPatterns2.Cap5
{
    public interface IVisitor
    {
        public void ImprimeSoma(Soma soma);

        public void ImprimeSubtracao(Subtracao subtracao);

        public void ImprimeDivisao(Divisao divisao);

        public void ImprimeMultiplicacao(Multiplicacao multiplicacao);

        public void ImprimeRaizQuadrada(RaizQuadrada raizQuadrada);

        public void ImprimeNumero(Numero numero);
    }
}
