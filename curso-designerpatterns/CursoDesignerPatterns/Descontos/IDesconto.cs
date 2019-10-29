using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPatterns.Descontos
{
    public interface IDesconto
    {
        double Desconta(Orcamento orcamento);
        IDesconto Proximo { get; set; }
    }
}
