using CursoDesignerPatterns.Descontos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPatterns.Impostos
{
    class IHIT : TemplateDeImpostoCondicional
    {
        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            IList<string> noOrcamento = new List<string>();

            foreach(Item item in orcamento.Itens)
            {
                if (noOrcamento.Contains(item.Nome))
                {
                    return true;
                }
                else
                {
                    noOrcamento.Add(item.GetNome);
                }
            }
            return false;
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * (0.01 * orcamento.Itens.Count);
        }
    }
}
