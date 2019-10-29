namespace curso_solid.Aula4
{
    public class Boleto
    {
        public double Valor { get; private set; }

        public Boleto(double valor)
        {
            this.Valor = valor;
        }
    }
}