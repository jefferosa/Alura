using CursoDesignerPatterns.Descontos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPatterns.Impostos
{
    class ICPP : TemplateDeImpostoCondicional
    {
        public ICPP(IImposto outroImposto) : base(outroImposto) { }
        public ICPP() : base() { }

        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor >= 500;
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07 + CalculoDoOutroImposto(orcamento);
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05 + CalculoDoOutroImposto(orcamento);
        }
    }
}
