using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPatterns
{
    public class CalculadorDeImposto
    {
        public void Calcula(Orcamento orcamento, IImposto estrategiaDeImposto)
        {
            double resultado = estrategiaDeImposto.Calcula(orcamento);
            Console.WriteLine(resultado);
        }
    }
}
