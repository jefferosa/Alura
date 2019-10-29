using System;

namespace CursoDesignerPatterns.Notas
{
    public class EnviadorDeEmail : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("enviando por e-mail");
        }
    }
}
