using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CarregarContas();
            }
            catch(Exception)
            {
                Console.WriteLine("Catch no metodo main");
            }
            Console.ReadLine();
        }

        private static void CarregarContas()
        {
            using(LeitorDeArquivos leitor = new LeitorDeArquivos("teste.txt"))
            {
                leitor.LerProximaLinha();
            }


            //LeitorDeArquivos leitor = null;
            //try
            //{
            //    leitor = new LeitorDeArquivos("contas.txt");

            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //}
            //catch(IOException)
            //{
            //    Console.WriteLine("Eceção do tipo IOException capturada e tratada");
                
            //}
            //finally
            //{
            //    if (leitor != null)
            //    {
            //        leitor.Fechar();
            //    }
            //}
        }
        private static void TestaInner()
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(50, 564654);
                ContaCorrente conta2 = new ContaCorrente(458, 457715);

                conta2.Transferir(10000, conta);
                conta.Depositar(100);
                Console.WriteLine(conta.Saldo);
                conta.Sacar(500);
            }
            catch (ArgumentException ex)
            {
                if (ex.ParamName == "numero")
                {

                }
                Console.WriteLine("Argumento com problema: " + ex.ParamName);
                Console.WriteLine("Ocorreu um erro do tipo ArgumentException");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exceção do tipo saldo insuficiente exception");
            }
            catch (OperacaoFinanceiraException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            Metodo();

            //ContaCorrente conta = new ContaCorrente(546, 754874);

            //Console.WriteLine(ContaCorrente.TaxaOperacao);


        }

        private static void Metodo()
        {
            TestaDivisao(1);
        }

        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);
            // Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exceção com número=" + numero + " e divisor=" + divisor);
                throw;
                Console.WriteLine("Código depois do throw");
            }
            //ContaCorrente conta = null;
            //Console.WriteLine(conta.Saldo);
        }
    }
}
