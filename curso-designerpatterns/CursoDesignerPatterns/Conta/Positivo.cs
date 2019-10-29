using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPatterns.Conta
{
    public class Positivo : IEstadoConta
    {
        public void Saca(Conta c, double valor)
        {
            c.Saldo -= valor;
        }

        public void Deposita(Conta c, double valor)
        {
            c.Saldo += valor;
        }
    }
}
