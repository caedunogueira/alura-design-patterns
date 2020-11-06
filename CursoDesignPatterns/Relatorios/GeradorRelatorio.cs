namespace CursoDesignPatterns.Relatorios
{
    public class GeradorRelatorio
    {
        public void Gerar(Relatorio relatorio, Banco banco) => relatorio.ImprimirContasDo(banco);
    }
}
