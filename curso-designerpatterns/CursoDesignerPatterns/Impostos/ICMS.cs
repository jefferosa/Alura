using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPatterns
{
    public class ICMS : IImposto
    {
        public ICMS(IImposto outroImposto) : base(outroImposto) { }
        public ICMS() : base() { }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1 + CalculoDoOutroImposto(orcamento);
        }
    }
}
