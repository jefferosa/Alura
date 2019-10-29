using System.Collections.Generic;

namespace curso_solid.Aula4
{
    public class Fatura
    {
        public string Cliente { get; private set; }
        public double Valor { get; set; }
        public List<Pagamento> Pagamentos { get; private set; }
        public bool Pago { get; set; }

        public Fatura(string cliente, double valor)
        {
            this.Cliente = cliente;
            this.Valor = valor;
            this.Pagamentos = new List<Pagamento>();
            this.Pago = false;
        }
        public void AdicionaPagamento(Pagamento pagamento)
        {
            this.Pagamentos.Add(pagamento);
            if (ValorTotalDosPagamentos() >= Valor)
            {
                this.Pago = true;
            }
        }

        private double ValorTotalDosPagamentos()
        {
            double total = 0;

            foreach(Pagamento pag in Pagamentos)
            {
                total += pag.Valor;
            }

            return total;
        }
    }
}