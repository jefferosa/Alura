using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPatterns.Conta
{
    public class Conta
    {
        public double Saldo { get;  set; }
        public Positivo Estado { get; internal set; }

        interface IEstadoConta
        {
            void Saca(Conta c, double valor);
            void Deposita(Conta c, double valor);
        }

        
    }
}
