using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPatterns.Investimento
{
    class RespostaEmXml : IResposta
    {
        public IResposta OutraResposta { get; set; }

        public RespostaEmXml(IResposta outraResposta)
        {
            this.OutraResposta = outraResposta;
        }
        

        public void Responde(Requisicao req, Conta1 conta)
        {
            if (req.Formato == Formato.XML)
            {
                Console.WriteLine("<conta><titular>" + conta.Titular + "</titular><saldo>" + conta.Saldo + "</saldo></conta>");
            }
            else
            {
                OutraResposta.Responde(req, conta);
            }
        }
    }
}
