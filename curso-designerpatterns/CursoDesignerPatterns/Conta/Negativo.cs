using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPatterns.Conta
{
    public class Negativo : IEstadoConta
    {
        public void Saca(Conta conta, double valor)
        {
            throw new Exception("Sua conta está negativa. Não podes sacar");
        }

        public void Deposita(Conta conta, double valor)
        {
            conta.Saldo += valor * 0.95;
            if (conta.Saldo > 0)
            {
                conta.Estado = new Positivo();
            }
        }
    }
}
