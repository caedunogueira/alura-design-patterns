using DesignPatterns2.Cap8;
using System;

namespace DesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente
            {
                Nome = "Victor",
                Endereco = "Rua Vergueiro",
                DataDeNascimento = DateTime.Now
            };
            var geradorXml = new GeradorDeXml<Cliente>();

            Console.WriteLine(geradorXml.GeraXml(cliente));
        }
    }
}
