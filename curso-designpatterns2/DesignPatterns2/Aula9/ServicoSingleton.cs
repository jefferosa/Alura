using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Aula9
{
    public class ServicoSingleton
    {
        private static Servico instancia = new Servico();

        public Servico Instancia
        {
            get
            {
                return instancia;
            }
        }
    }
}
