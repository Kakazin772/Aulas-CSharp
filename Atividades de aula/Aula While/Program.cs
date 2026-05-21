using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            double raiz, a;

            Console.Write("Digite um numero: ");
            a = double.Parse(Console.ReadLine());

            while (a >= 0.0)
            {
                raiz = Math.Sqrt(a);

                Console.WriteLine($"A raiz de {a} é {raiz:F2}");

                Console.Write("Digite um numero: ");
                a = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Numero Negativo");
        }
    }
}