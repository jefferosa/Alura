using CursoDesignerPatterns.Investimento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPatterns.Filtros
{
    public class FiltroMesmMes : Filtro
    {
        public FiltroMesmMes(Filtro outroFiltro) : base(outroFiltro) { }
        public FiltroMesmMes() : base() { }

        public override IList<Conta1> Filtra(IList<Conta1> contas)
        {
            IList<Conta1> filtrada = new List<Conta1>();
            foreach(Conta1 c in contas)
            {
                if (c.DataAbertura.Month == DateTime.Now.Month && c.DataAbertura.Year == DateTime.Now.Year)
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
