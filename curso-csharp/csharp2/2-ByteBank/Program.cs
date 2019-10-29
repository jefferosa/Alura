using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc=-1;
            new ContaCorrente();
            ContaCorrente Cadastro = new ContaCorrente();

            while (opc != 0)
            {
                opc = Cadastro.Menu(opc);
                switch (opc)
                {
                    case 1:
                        Cadastro.Cad(Cadastro);
                        break;
                    case 2:
                        Cadastro.Saque(Cadastro);
                        break;
                    case 3:
                        Cadastro.Deposito(Cadastro);
                        break;
                    case 4:
                        Cadastro.Consulta(Cadastro);
                        break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Você saiu do programa!");
                        Console.ReadLine();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção Inválida!!");
                        break;
                }
            }
        }
    }
}
