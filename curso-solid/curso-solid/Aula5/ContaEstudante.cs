using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    class ContaEstudante : ContaComum
    {

        public override void SomaInvestimento()
        {
            throw new Exception("Conta de estudante não rende");
        }
    }
}
