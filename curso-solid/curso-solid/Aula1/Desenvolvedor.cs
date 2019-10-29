using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_solid
{
    public class Desenvolvedor : Cargo
    {
        public Desenvolvedor(IRegraDeCalculo regra) : base(regra)
        {

        }
    }
}
