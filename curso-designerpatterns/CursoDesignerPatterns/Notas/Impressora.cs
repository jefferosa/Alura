using System;

namespace CursoDesignerPatterns.Notas
{
    public class Impressora : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("imprimindo notaFiscal");
        }
    }
}
