using System;

namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco conta = new Banco(0.00);
            char resp;

            Console.WriteLine("Entre com o numero da conta: ");
            conta.NumeroDaConta = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Entre com o titular da conta: ");
            conta.NomeTitular = Console.ReadLine();

            Console.WriteLine("Havera deposito inicial? (S/N): ");
            resp = char.Parse(Console.ReadLine());

            if (resp == 'S')
            {
                Console.WriteLine("Entre com o valor do deposito inicial: ");
                conta.Saldo = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine("Entre com um valor para deposito: ");
            conta.Deposito(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine("Entre com um valor para saque: ");
            conta.Saque(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
        }
    }
}