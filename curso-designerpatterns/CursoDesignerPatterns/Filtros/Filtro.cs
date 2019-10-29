using CursoDesignerPatterns.Investimento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPatterns.Filtros
{
    public abstract class Filtro
    {
        protected Filtro OutroFiltro { get; private set; }

        public Filtro(Filtro outroFiltro)
        {
            this.OutroFiltro = outroFiltro;
        }

        public Filtro() { }

        public abstract IList<Conta1> Filtra(IList<Conta1> contas);

        protected IList<Conta1> Proximo(IList<Conta1> contas)
        {
            if (OutroFiltro != null)
            {
                return OutroFiltro.Filtra(contas);
            }
            else
            {
                return new List<Conta1>();
            }
        }
    }
}
