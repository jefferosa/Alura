using System;

namespace curso_solid.Aula2
{
    public class EnviadorDeEmail : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Enviando Email");
        }
    }
}