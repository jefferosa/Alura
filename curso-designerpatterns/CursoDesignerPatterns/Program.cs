using CursoDesignerPatterns.Impostos;
using CursoDesignerPatterns.Notas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            NotaFiscalBuilder builder = new NotaFiscalBuilder();
            builder.AdicionaAcao(new Multiplicador(5));
            builder.AdicionaAcao(new Multiplicador(7));
            builder.AdicionaAcao(new Multiplicador(1.5));

            NotaFiscal notaFiscal = builder.ParaEmpresa("Stark")
                                .ComCnpj("54698798756498")
                                .ComItem(new ItemDaNota("item 1", 1000.0))
                                .ComItem(new ItemDaNota("item 2", 2020.0))
                                .ComItem(new ItemDaNota("item 3", 3440.0))
                                .ComObservacoes("entregar notaFiscal pessoalmente")
                                .NaDataAtual()
                                .Constroi();
            Console.ReadKey();
        }
    }
}
