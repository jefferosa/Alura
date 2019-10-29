using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            new ContaCorrente();
            ContaCorrente conta1 = new ContaCorrente();
            Console.WriteLine("Infome o nome do Titular: ");
            conta1.titular = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Infome a agência: ");
            conta1.agencia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Infome o numero da conta: ");
            conta1.numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Infome o saldo: ");
            conta1.saldo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Titular: " + conta1.titular);
            Console.WriteLine("Agência: " + conta1.agencia);
            Console.WriteLine("Número: " + conta1.numero);
            Console.WriteLine("Saldo: " + conta1.saldo);
            Console.ReadLine();
        }
    }
}
