using System;
using System.Diagnostics.CodeAnalysis;

namespace CursoDesignPatterns.Investimentos
{
    public class ContaBancaria : IEquatable<ContaBancaria>
    {
        ISaldo StatusSaldo { get; set; }

        public string Titular { get; }
        public string Agencia { get; }
        public string Numero { get; }
        public decimal Saldo { get; private set; }
        public DateTime DataAbertura { get; }

        public ContaBancaria(decimal saldo)
        {
            StatusSaldo = new SaldoPositivo();
            Saldo = saldo;
        }

        public ContaBancaria(string titular, decimal saldo) : this(saldo) => Titular = titular;
            
        public ContaBancaria(string titular, string agencia, string numero, decimal saldo) : this(titular, saldo)
        {
            Agencia = agencia;
            Numero = numero;
        }

        public ContaBancaria(string titular, string agencia, string numero, decimal saldo, DateTime dataAbertura) : this(titular, agencia, numero, saldo) =>
            DataAbertura = dataAbertura;

        public void Depositar(decimal valor) => StatusSaldo.Depositar(this, valor);

        public void Sacar(decimal valor) => StatusSaldo.Sacar(this, valor);

        public bool PossuiSaldoMenorQue100() => Saldo < 100m;

        public bool PossuiSaldoMaiorQue500Mil() => Saldo > 500000m;

        public bool AberturaNoMesCorrente() => 
            DataAbertura.Month == DateTime.Today.Month &&
            DataAbertura.Year == DateTime.Today.Year;

        public bool Equals([AllowNull] ContaBancaria other)
        {
            if (other is null) return false;

            return Titular == other.Titular && 
                   Agencia == other.Agencia && 
                   Numero == other.Numero;
        }

        public override bool Equals(object obj) => Equals(obj as ContaBancaria);
        public override int GetHashCode() => (Titular, Agencia, Numero).GetHashCode();

        #region Status dos Saldo
        interface ISaldo
        {
            void Sacar(ContaBancaria conta, decimal valor);

            void Depositar(ContaBancaria conta, decimal valor);
        }

        class SaldoPositivo : ISaldo
        {
            public void Depositar(ContaBancaria conta, decimal valor)
            {
                valor *= 0.98m;
                conta.Saldo += valor;
            }

            public void Sacar(ContaBancaria conta, decimal valor)
            {
                conta.Saldo -= valor;

                if (conta.Saldo < 0)
                    conta.StatusSaldo = new SaldoNegativo();
            }
        }

        class SaldoNegativo : ISaldo
        {
            public void Depositar(ContaBancaria conta, decimal valor)
            {
                valor *= 0.95m;
                conta.Saldo += valor;

                if (conta.Saldo >= 0)
                    conta.StatusSaldo = new SaldoPositivo();
            }

            public void Sacar(ContaBancaria conta, decimal valor) => throw new Exception("Não é possível realizar saques nessa conta pois está com saldo negativo.");
        }
        #endregion
    }
}
