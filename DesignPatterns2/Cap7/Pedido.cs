using System;

namespace DesignPatterns2.Cap7
{
    public class Pedido
    {
        public string Cliente { get; set; }
        public double Valor { get; set; }
        public DateTime DataFinalizacao { get; set; }
        public Status Status { get; set; }

        public Pedido(string cliente, double valor)
        {
            Cliente = cliente;
            Valor = valor;
            Status = Status.Novo;
        }

        public void Paga() => Status = Status.Pago;

        public void Finaliza()
        {
            Status = Status.Entregue;
            DataFinalizacao = DateTime.Now;
        }
    }
}
