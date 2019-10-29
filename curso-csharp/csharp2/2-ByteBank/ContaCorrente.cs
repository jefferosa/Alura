using System;



public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numero;
    public double saldo;

    public void Saque(ContaCorrente Cadastro)
    {
        double valor;
        Console.Clear();
        Console.WriteLine("Informe o Valor que deseja sacar: ");
        valor = Convert.ToDouble(Console.ReadLine());
        if (this.saldo < valor)
        {
            Console.WriteLine("\nSaldo Indisponível para Saque!");
        }
        else
        {
            this.saldo -= valor;
            Console.WriteLine("\nSaque Efetuado com Sucesso!");
        }
    }
    public void Deposito(ContaCorrente Cadastro)
    {
        Console.Clear();
        Console.WriteLine("Informe o Valor que deseja depositar: ");
        this.saldo += Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nDeposito realizado com sucesso!");
    }
    public void Cad(ContaCorrente Cadastro)
    {
        Console.Clear();
        Console.WriteLine("Informe o nome do Titular: ");
        this.titular = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Informe a Agência: ");
        this.agencia = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Infore o número da Conta: ");
        this.numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o Saldo: ");
        this.saldo = Convert.ToDouble(Console.ReadLine());
    }
    public void Consulta(ContaCorrente Cadastro)
    {
        Console.Clear();
        Console.WriteLine("\nTitular: " + this.titular);
        Console.WriteLine("Agência: " + this.agencia);
        Console.WriteLine("Número da Conta: " + this.numero);
        Console.WriteLine("Saldo: \n" + this.saldo);
        Console.WriteLine("\n\nTecle enter para voltar para o Menu!!!");
        Console.ReadLine();
    }
    public int Menu(int opc)
    {
        Console.Clear();
        Console.WriteLine("\n!!MENU!!");
        Console.WriteLine("\n1-Cadastro de Conta");
        Console.WriteLine("2-Saque");
        Console.WriteLine("3-Deposito");
        Console.WriteLine("4-Consultar Cadastro e Saldo");
        Console.WriteLine("0-Sair\n");
        opc = Convert.ToInt32(Console.ReadLine());
        return opc;
    }
}