using CursoDesignerPatterns.Descontos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPatterns.Impostos
{
    public class IKCV : TemplateDeImpostoCondicional
    {
        public IKCV(IImposto outroImposto) : base(outroImposto) { }
        public IKCV() : base() { }

        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && temItemMaiorQue100ReaisNo(orcamento);
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.10 + CalculoDoOutroImposto(orcamento);
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06 + CalculoDoOutroImposto(orcamento);
        }

        private bool temItemMaiorQue100ReaisNo(Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Valor > 100) return true;
            }

            return false;
        }
    }
}
