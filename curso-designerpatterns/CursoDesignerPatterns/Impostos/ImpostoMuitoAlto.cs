using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPatterns.Impostos
{
    class ImpostoMuitoAlto : IImposto
    {
        public ImpostoMuitoAlto(IImposto outroImposto) : base(outroImposto) { }
        public ImpostoMuitoAlto() : base() { }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.2 + CalculoDoOutroImposto(orcamento);
        }
    }
}
