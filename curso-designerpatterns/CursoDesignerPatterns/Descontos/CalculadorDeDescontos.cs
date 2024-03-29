﻿using CursoDesignerPatterns.Descontos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPatterns.Impostos
{
    public class CalculadorDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
            IDesconto d1 = new DescontoMaisDeQuinhentosReais();
            IDesconto d2 = new DescontoCincoItens();
            IDesconto d3 = new DescontoPorVendaCasada();
            IDesconto d4 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;
            d3.Proximo = d4;

            return d1.Desconta(orcamento);
        }
    }
}
