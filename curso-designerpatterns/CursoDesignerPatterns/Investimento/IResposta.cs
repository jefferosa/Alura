using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPatterns.Investimento
{
    interface IResposta
    {
        void Responde(Requisicao req, Conta1 conta);
        IResposta OutraResposta { get; set; }
    }
}
