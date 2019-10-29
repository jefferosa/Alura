using DesignPatterns2.Aula4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Aula5
{
    public interface IVisitor
    {
        void ImprimeSoma(Soma soma);
        void ImprimeSubtracao(Subtracao subtracao);
        void ImprimeNumero(Numero numero);
        void ImprimeDivisao(Divisao divisao);
        void ImprimeMultiplicacao(Multiplicacao multiplicacao);
        void ImprimeRaizQuadrada(RaizQuadrada raizQuadrada);
    }
}
