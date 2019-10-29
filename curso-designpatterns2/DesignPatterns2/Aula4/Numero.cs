using DesignPatterns2.Aula5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Aula4
{
    public class Numero : IExpressao
    {

        public int Valor { get; set; }
        public Numero(int numero)
        {
            this.Valor = numero;
        }

        public int Avalia()
        {
            return Valor;
        }

        public void Aceita(IVisitor visitor)
        {
            visitor.ImprimeNumero(this);
        }
    }
}
