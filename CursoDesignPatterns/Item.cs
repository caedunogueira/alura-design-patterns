namespace CursoDesignPatterns
{
    public class Item
    {
        public string Nome { get; }
        public double Valor { get; }

        public Item(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }
    }
}
