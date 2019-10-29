using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularBonificacao();

            UsarSistema();

            Console.ReadLine(); 
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor Cad2 = new Diretor("43256423542364");
            Cad2.Nome = "Stark";
            Cad2.Senha = "123";

            GerenteDeConta Cad4 = new GerenteDeConta("4362363274372");
            Cad4.Nome = "America";
            Cad4.Senha = "474";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "44";

            sistemaInterno.Logar(parceiro, "44");
            sistemaInterno.Logar(Cad2, "123");
            sistemaInterno.Logar(Cad4, "474");
        }

        public static void CalcularBonificacao() 
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionario Cad1 = new Designer("824542354352");
            Cad1.Nome = "Irineu";

            Diretor Cad2 = new Diretor("43256423542364");
            Cad2.Nome = "Stark";

            Funcionario Cad3 = new Auxiliar("345423624");
            Cad3.Nome = "Roger";

            GerenteDeConta Cad4 = new GerenteDeConta("4362363274372");
            Cad4.Nome = "America";

            Desenvolvedor Cad5 = new Desenvolvedor("154262367477");
            Cad5.Nome = "Uzumaki"; 

            gerenciadorBonificacao.Registrar(Cad1);
            gerenciadorBonificacao.Registrar(Cad2);
            gerenciadorBonificacao.Registrar(Cad3);
            gerenciadorBonificacao.Registrar(Cad4);
            gerenciadorBonificacao.Registrar(Cad5);

            Console.WriteLine("Total de bonificações do mês " +
                gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}