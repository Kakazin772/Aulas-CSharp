using System;

namespace Funcao
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, maior, a, b, c, menor;

            Console.WriteLine("Digite 3 numeros");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());

            maior = Maior(n1, n2, n3);

            Console.WriteLine($"O maior entre eles é {maior}");

            Console.WriteLine("Digite outros 3 numeros:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            menor = Menor(a, b, c);

            Console.WriteLine($"O menor entre eles é {menor}");

        }

        static int Maior(int a, int b, int c)
        {
            int m;

            if (a > b && a > c)
            {
                m = a;
            }
            else
            {
                if (b > c && b > a)
                {
                    m = b;
                }
                else
                {
                    m = c;
                }
            }

            return m;
        }

        static int Menor(int a, int b, int c)
        {
            int m;

            if (a < b && a < c)
            {
                m = a;
            }
            else
            {
                if (b < c && b < a)
                {
                    m = b;
                }
                else
                {
                    m = c;
                }
            }

            return m;
        }
    }
}