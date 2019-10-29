using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPatterns.Descontos
{
    public class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (Contem("Caneta", orcamento) && Contem("Lapis", orcamento))
            {
                return orcamento.Valor * 0.05;
            }
            else
            {
                return Proximo.Desconta(orcamento);
            }
        }

        private bool Contem(string nomeDoItem, Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Nome.Equals(nomeDoItem))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
