using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPatterns.Investimento
{
    public class Conta1
    {
        public string Titular { get; private set; }
        public double Saldo { get; private set; }
        public string Nome { get; internal set; }
        public string Numero { get; internal set; }

        internal void Deposita(double valor)
        {
            Saldo += valor;
        }

        public string Agencia { get; internal set; }
        public DateTime DataAbertura { get; internal set; }

        public Conta1(String titular, double saldo)
        {
            this.Titular = titular;
            this.Saldo = saldo;
        }
    }

}
