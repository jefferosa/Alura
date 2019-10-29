using CursoDesignerPatterns.Investimento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPatterns.Relatorio
{
    class RelatorioComplexo : Relatorio
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("Banco ssa");
            Console.WriteLine("Avenida Maracanã, 1234");
            Console.WriteLine("(47) 7895-5678");
        }

        protected override void Rodape()
        {
            Console.WriteLine("banco@gmail.com");
            Console.WriteLine(DateTime.Now);
        }
        
        protected override void Corpo(IList<Conta1> contas)
        {
            foreach (Conta1 c in contas)
            {
                Console.WriteLine(c.Nome + " - " + c.Numero + " - " + c.Agencia + " - " + c.Saldo);
            }
        }
    }
}
