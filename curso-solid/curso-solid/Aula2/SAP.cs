﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_solid.Aula2
{
    public class SAP : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Enviando Nota Para O SAP");
        }
    }
}
