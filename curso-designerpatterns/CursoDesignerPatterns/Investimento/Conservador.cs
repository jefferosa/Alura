using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPatterns.Investimento
{
    public class Conservador : IInvestimento
    {
        public double Calcula(Conta1 conta)
        {
            return conta.Saldo * 0.008;
        }
    }
}
