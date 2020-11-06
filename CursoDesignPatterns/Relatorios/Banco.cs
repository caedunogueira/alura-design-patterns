using CursoDesignPatterns.Investimentos;
using System.Collections.Generic;

namespace CursoDesignPatterns.Relatorios
{
    public class Banco
    {
        public string Nome { get; }
        public string Endereco { get; }
        public string Telefone { get; }
        public string Email { get; }
        public IEnumerable<ContaBancaria> Contas { get; }

        public Banco(string nome, string endereco, string telefone, string email, IEnumerable<ContaBancaria> contas)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            Email = email;
            Contas = contas;
        }
    }
}
