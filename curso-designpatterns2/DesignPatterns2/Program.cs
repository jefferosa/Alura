using DesignPatterns2.Aula2;
using DesignPatterns2.Aula3;
using DesignPatterns2.Aula4;
using DesignPatterns2.Aula5;
using DesignPatterns2.Aula6;
using DesignPatterns2.Aula7;
using DesignPatterns2.Aula8;
using DesignPatterns2.Aula9;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DesignPatterns2
{
    class Program
    {
        public static void Main(string[] args)
        {
            EmpresaFacade fachada = new EmpresaFacadeSingleton().Instancia;
        }
    }

}
