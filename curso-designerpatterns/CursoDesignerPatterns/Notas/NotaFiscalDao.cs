using System;

namespace CursoDesignerPatterns.Notas
{
    public class NotaFiscalDao : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("salvando no banco");
        }
    }
}
