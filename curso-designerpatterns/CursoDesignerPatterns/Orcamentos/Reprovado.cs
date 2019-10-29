using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPatterns.Descontos
{
    public class Reprovado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orcamentos reprovados não recebem desconto extra");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento foi reprovado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento ja foi reprovado, não pode ser reprovado denovo");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}
