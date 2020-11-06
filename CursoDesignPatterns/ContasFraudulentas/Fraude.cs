using CursoDesignPatterns.Investimentos;
using System.Collections.Generic;

namespace CursoDesignPatterns.ContasFraudulentas
{
    public abstract class Fraude
    {
        public Fraude OutraFraude { get; }

        protected Fraude(Fraude outraFraude = null) => OutraFraude = outraFraude;

        public abstract IReadOnlyCollection<ContaBancaria> Identificar(IReadOnlyCollection<ContaBancaria> contas);

        protected IReadOnlyCollection<ContaBancaria> AplicarOutraIdentificacao(IReadOnlyCollection<ContaBancaria> contas)
        {
            if (OutraFraude == null) return null;

            return OutraFraude.Identificar(contas);
        }
    }
}
