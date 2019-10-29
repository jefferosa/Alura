using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPatterns.Investimento
{
    public class RealizadorDeInvestimentos
    {
        public void Realiza(Conta1 conta, IInvestimento investimento)
        {
            double resultado = investimento.Calcula(conta);
            conta.Deposita(resultado * 0.75);
            Console.WriteLine("Novo Saldo: " + conta.Saldo);
        }
    }
}
