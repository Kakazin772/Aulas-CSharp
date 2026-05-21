using System;

namespace Empregrado
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1, f2;
            
            f1 = new Funcionario();
            f2 = new Funcionario();

            f1.Salario = double.Parse(Console.ReadLine());
            f1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine($"{f1.SalarioAnual()}");
            Console.WriteLine($"{f2.SalarioAnual()}");
        }
    }
}