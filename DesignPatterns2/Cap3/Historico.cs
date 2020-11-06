using System.Collections.Generic;

namespace DesignPatterns2.Cap3
{
    public class Historico
    {
        private IList<Estado> estados = new List<Estado>();

        public void Adiciona(Estado estado) => estados.Add(estado);

        public Estado Pega(int indice) => estados[indice];
    }
}
