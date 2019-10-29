using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPatterns.Investimento
{
    class RespostaEmPorcento : IResposta
    {
        public IResposta OutraResposta { get; set; }

        public RespostaEmPorcento(IResposta outraResposta)
        {
            this.OutraResposta = outraResposta;
        }

        public RespostaEmPorcento()
        {
            this.OutraResposta = null; // nao recebi a proxima!
        }

        public void Responde(Requisicao req, Conta1 conta)
        {
            if (req.Formato == Formato.PORCENTO)
            {
                Console.WriteLine(conta.Titular + '%' + conta.Saldo);
            }
            else if (OutraResposta != null)
            {
                OutraResposta.Responde(req, conta);
            }
            else
            {
                // não existe próxima na corrente, e ninguém atendeu a requisição!
                // poderíamos não ter feito nada aqui, caso não fosse necessário!
                throw new Exception("Formato de resposta não encontrado");
            }
        }
    }
}
