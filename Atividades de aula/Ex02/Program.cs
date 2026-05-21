using System;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaSalario pf, sf;
            float media;

            pf = new PessoaSalario();
            sf = new PessoaSalario();

            Console.WriteLine("Dados do primeiro funcionario:");
            Console.Write("Nome: ");
            pf.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            pf.Salario = float.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionario:");
            Console.Write("Nome: ");
            sf.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            sf.Salario = float.Parse(Console.ReadLine());

            media = (sf.Salario + pf.Salario) / 2;

            Console.WriteLine($"Salario medio = {media:F2}");
        }
    }
}