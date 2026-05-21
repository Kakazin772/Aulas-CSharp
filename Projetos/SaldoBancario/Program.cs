using SaldoBancario.Entities;
using System;
using SaldoBancario.Entities.Exception;

namespace SaldoBancario
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerocont;
            string nome;
            double limite, saldo, amount;

            Account conta;

            Console.WriteLine("Entre com os dados da conta:");
            Console.Write("Numero: ");
            numerocont = int.Parse(Console.ReadLine());
            Console.Write("Propietario: ");
            nome = Console.ReadLine();
            Console.Write("Saldo inicial: ");
            saldo = double.Parse(Console.ReadLine());
            Console.Write("Limite de saque: ");
            limite = double.Parse(Console.ReadLine());

            conta = new Account(numerocont, nome, saldo, limite);

            try
            {
                Console.Write("Entre com o valor do saque: ");
                amount = double.Parse(Console.ReadLine());

                conta.Withdraw(amount);

                Console.WriteLine($"Novo saldo: {conta.Balance:F2}");
            }
            catch(AccountException e)
            {
                Console.WriteLine($"Erro de saque: {e.Message}");
            }
        }
    }
}