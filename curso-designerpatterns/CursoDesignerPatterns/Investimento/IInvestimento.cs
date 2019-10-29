using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPatterns.Investimento
{
    public interface IInvestimento
    {
        double Calcula(Conta1 conta);
    }
}
