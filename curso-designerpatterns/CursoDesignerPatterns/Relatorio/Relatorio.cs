using CursoDesignerPatterns.Investimento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPatterns.Relatorio
{
    abstract class Relatorio
    {
        protected abstract void Cabecalho();
        protected abstract void Rodape();
        protected abstract void Corpo(IList<Conta1> contas);

        public void Imprime(IList<Conta1> contas)
        {
            Cabecalho();
            Corpo(contas);
            Rodape();
        }
    }
}
