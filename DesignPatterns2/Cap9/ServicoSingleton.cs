namespace DesignPatterns2.Cap9
{
    public class ServicoSingleton
    {
        private static readonly Servico servico = new Servico();

        public Servico Instancia => servico;
    }
}
