using CursoDesignerPatterns.Investimento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPatterns.Filtros
{
    public class FiltroMaisDe500MilReais : Filtro
    {
        public FiltroMaisDe500MilReais(Filtro outroFiltro) : base(outroFiltro) { }
        public FiltroMaisDe500MilReais() : base() { }

        public override IList<Conta1> Filtra(IList<Conta1> contas)
        {
            IList<Conta1> filtrada = new List<Conta1>();
            foreach(Conta1 c in contas)
            {
                if (c.Saldo > 500000)
                {
                    filtrada.Add(c);
                }
            }

            foreach(Conta1 c in contas)
            {
                filtrada.Add(c);
            }

            return filtrada;
        }
    }
}
