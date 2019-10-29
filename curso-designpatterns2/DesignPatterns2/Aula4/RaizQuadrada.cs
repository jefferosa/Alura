using DesignPatterns2.Aula5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Aula4
{
    public class RaizQuadrada : IExpressao
    {
        private IExpressao Expressao;

        public RaizQuadrada(IExpressao expressao)
        {
            this.Expressao = expressao;
        }

        public int Avalia()
        {
            return (int)Math.Sqrt(Expressao.Avalia());
        }

        public void Aceita(IVisitor visitor)
        {
            visitor.ImprimeRaizQuadrada(this);
        }
    }
}
