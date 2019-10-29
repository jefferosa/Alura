using CursoDesignerPatterns.Investimento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPatterns.Relatorio
{
    class RelatorioSimples : Relatorio
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("Banco XYZ");
        }

        protected override void Rodape()
        {
            Console.WriteLine("(11) 1234-5678");
        }

        protected override void Corpo(IList<Conta1> contas)
        {
            foreach (Conta1 c in contas)
            {
                Console.WriteLine(c.Nome + " - " + c.Saldo);
            }
        }
    }
}
