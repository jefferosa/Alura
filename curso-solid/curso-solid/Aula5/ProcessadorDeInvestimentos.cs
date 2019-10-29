using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public class ProcessadorDeInvestimentos
    {

        public static void main(string[] args)
        {

            foreach (ContaComum conta in contasDoBanco())
            {
                conta.SomaInvestimento();

                Console.WriteLine("Novo Saldo:" + conta.Saldo);
            }
        }
    }
}
