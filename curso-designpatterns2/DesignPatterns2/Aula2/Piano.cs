using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Aula2
{
    public class Piano
    {
        public void Toca(List<INota> musica)
        {
            foreach (INota nota in musica)
            {
                Console.Beep(nota.Frequencia, 300);
            }

        }
    }
}
