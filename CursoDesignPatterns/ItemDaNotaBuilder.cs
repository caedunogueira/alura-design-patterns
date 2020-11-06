namespace CursoDesignPatterns
{
    public class ItemDaNotaBuilder
    {
        private string _nome;
        private double _valor;

        public ItemDaNotaBuilder ComNome(string nome)
        {
            _nome = nome;
            return this;
        }

        public ItemDaNotaBuilder ComValor(double valor)
        {
            _valor = valor;
            return this;
        }

        public ItemDaNota Constroi() => new ItemDaNota(_nome, _valor);
    }
}
