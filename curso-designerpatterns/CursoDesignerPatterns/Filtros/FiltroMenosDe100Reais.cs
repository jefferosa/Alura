using CursoDesignerPatterns.Investimento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignerPatterns.Filtros
{
    public class FiltroMenosDe100Reais : Filtro
    {
        public FiltroMenosDe100Reais(Filtro outroFIltro) : base(outroFIltro) { }
        public FiltroMenosDe100Reais() : base() { }

        public override IList<Conta1> Filtra(IList<Conta1> contas)
        {
            IList<Conta1> filtrada = new List<Conta1>();
            foreach(Conta1 c in contas)
            {
                if (c.Saldo < 100)
                {
                    filtrada.Add(c);
                }
            }

            foreach(Conta1 c in Proximo(contas))
            {
                filtrada.Add(c);
            }

            return filtrada;
        }
    }
}
