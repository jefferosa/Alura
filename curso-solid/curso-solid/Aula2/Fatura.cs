﻿namespace curso_solid.Aula2
{
    public class Fatura
    {
        public double ValorMensal { get; set; }
        public string Cliente { get; private set; }

        public Fatura(double valorMensal, string cliente)
        {
            this.ValorMensal = valorMensal;
            this.Cliente = cliente;
        }
    }
}