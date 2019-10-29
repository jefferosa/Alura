using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPatterns.Notas
{
    public class NotaFiscalBuilder
    {
        private String RazaoSocial { get; set; }
        private String Cnpj { get; set; }
        private List<ItemDaNota> todosItens = new List<ItemDaNota>();
        private double ValorBruto { get; set; }
        private double Impostos { get; set; }
        private String Observacoes { get; set; }
        private DateTime Data { get; set; }
        private IList<IAcaoAposGerarNota> todasAcoesASeremExecutadas = new List<IAcaoAposGerarNota>();

        public NotaFiscalBuilder ParaEmpresa(String razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(String cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder ComItem(ItemDaNota item)
        {
            todosItens.Add(item);
            ValorBruto += item.Valor;
            Impostos += item.Valor * 0.05;

            return this;
        }

        public NotaFiscalBuilder ComObservacoes(String observacoes)
        {
            this.Observacoes = observacoes;

            return this;
        }

        public NotaFiscalBuilder NaDataAtual()
        {
            this.Data = DateTime.Now;

            return this;
        }

        public NotaFiscal Constroi()
        {
            NotaFiscal notaFiscal = new NotaFiscal(RazaoSocial, Cnpj, ValorBruto, Impostos, Data, Observacoes);

            foreach (IAcaoAposGerarNota acao in todasAcoesASeremExecutadas)
            {
                acao.Executa(notaFiscal);
            }

            return notaFiscal;
        }

        public NotaFiscalBuilder()
        {
            this.todasAcoesASeremExecutadas = new List<IAcaoAposGerarNota>();
        }

        public void AdicionaAcao(IAcaoAposGerarNota novaAcao)
        {
            this.todasAcoesASeremExecutadas.Add(novaAcao);
        }
    }
}
