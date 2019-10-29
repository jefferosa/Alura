using System;

namespace CursoDesignerPatterns
{
    public class Item
    {
        public string GetNome { get; internal set; }

        public String Nome { get; private set; }
        public double Valor { get; private set; }

        public Item(String nome, double valor)
        {
            this.Nome = nome;
            this.Valor = valor;
        }
    }
}