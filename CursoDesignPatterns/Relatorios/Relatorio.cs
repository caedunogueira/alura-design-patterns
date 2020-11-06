using CursoDesignPatterns.Investimentos;
using System;
using System.Collections.Generic;

namespace CursoDesignPatterns.Relatorios
{
    public abstract class Relatorio
    {
        public void ImprimirContasDo(Banco banco)
        {
            ImprimirCabecalho(banco);
            ImprimirEspacoEntreAsSecoes();
            ImprimirCorpo(banco.Contas);
            ImprimirEspacoEntreAsSecoes();
            ImprimirRodape(banco);
        }

        protected abstract void ImprimirCabecalho(Banco banco);
        protected abstract void ImprimirCorpo(IEnumerable<ContaBancaria> contas);
        protected abstract void ImprimirRodape(Banco banco);

        private void ImprimirEspacoEntreAsSecoes()
        {
            for (var i = 0; i < 5; i++)
                Console.WriteLine();
        }
    }
}
