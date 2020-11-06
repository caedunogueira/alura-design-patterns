using System;

namespace CursoDesignPatterns
{
    public class Multiplicador : IAcaoAposGerarNota
    {
        public double Fator { get; }

        public Multiplicador(double fator) => Fator = fator;

        public void Executa(NotaFiscal nf) => Console.WriteLine($"Valor bruto da nota R$ {nf.ValorBruto:#,##0.00} multiplicado por {Fator}: R$ {(nf.ValorBruto * Fator):#,##0.00}");
    }
}
