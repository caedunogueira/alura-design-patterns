using System;
using System.Collections.Generic;

namespace CursoDesignPatterns
{
    public class NotaFiscalBuilder
    {
        private IList<IAcaoAposGerarNota> todasAcoesASeremExecutadas = new List<IAcaoAposGerarNota>();

        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public string Observacoes { get; private set; }
        public DateTime Data { get; private set; }

        private double valorTotal;
        private double impostos;
        private IList<ItemDaNota> todosItens = new List<ItemDaNota>();

        public NotaFiscalBuilder() => Data = DateTime.Now;

        public NotaFiscalBuilder(IList<IAcaoAposGerarNota> acoes) : this() => todasAcoesASeremExecutadas = acoes;

        public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
        {
            RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(string cnpj)
        {
            Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(string observacoes)
        {
            Observacoes = observacoes;
            return this;
        }

        public NotaFiscalBuilder NaData(DateTime data)
        {
            Data = data;
            return this;
        }

        public NotaFiscalBuilder Com(ItemDaNota itemNovo)
        {
            todosItens.Add(itemNovo);
            valorTotal += itemNovo.Valor;
            impostos += itemNovo.Valor * 0.05;
            
            return this;
        }

        public void AdicionaAcao(IAcaoAposGerarNota novaAcao) => todasAcoesASeremExecutadas.Add(novaAcao);

        public NotaFiscal Constroi()
        {
            var nf = new NotaFiscal(RazaoSocial, Cnpj, Data, valorTotal, impostos, todosItens, Observacoes);

            foreach (var acao in todasAcoesASeremExecutadas)
                acao.Executa(nf);

            return nf;
        }
    }
}
