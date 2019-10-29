using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPatterns.Descontos
{
    public abstract class TemplateDeImpostoCondicional : IImposto
    {
        public TemplateDeImpostoCondicional(IImposto outroImposto) : base(outroImposto) { }
        public TemplateDeImpostoCondicional() : base() { }

        public override double Calcula(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
            {
                return MaximaTaxacao(orcamento);
            }

            return MinimaTaxacao(orcamento);
        }

        protected abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
        protected abstract double MaximaTaxacao(Orcamento orcamento);
        protected abstract double MinimaTaxacao(Orcamento orcamento);
    }
}
