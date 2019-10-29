using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPatterns.Conta
{
    public interface IEstadoConta
    {
        void Saca(Conta conta, double valor);
        void Deposita(Conta conta, double valor);
    }
}
