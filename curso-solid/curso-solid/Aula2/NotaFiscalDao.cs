using System;

namespace curso_solid.Aula2
{
    public class NotaFiscalDao : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Persistindo Nota");
        }
    }
}