using System;

namespace DesignPatterns2.Cap3
{
    public class Contrato
    {
        public DateTime Data { get; private set; }
        public string Cliente { get; private set; }
        public TipoContrato Tipo { get; private set; }

        public Contrato(DateTime data, string cliente, TipoContrato tipo)
        {
            Data = data;
            Cliente = cliente;
            Tipo = tipo;
        }

        public void Avanca()
        {
            switch (Tipo)
            {
                case TipoContrato.Novo:
                    Tipo = TipoContrato.EmAndamento;
                    break;
                case TipoContrato.EmAndamento:
                    Tipo = TipoContrato.Acertado;
                    break;
                case TipoContrato.Acertado:
                    Tipo = TipoContrato.Concluido;
                    break;
                case TipoContrato.Concluido:
                default:
                    break;
            }
        }

        public Estado SalvaEstado() => new Estado(new Contrato(Data, Cliente, Tipo));
    }
}
