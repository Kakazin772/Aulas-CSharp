using Aula_classe_e_atributo;
using System;

namespace Classe_e_atributo
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            double area1, area2;
            char maior;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo x");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            area1 = x.Area();

            Console.WriteLine("Entre com as medidas do triangulo y");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            area2 = y.Area();

            if (area1 > area2)
            {
                maior = 'X';
            }
            else
            {
                if (area2 > area1)
                {
                    maior = 'Y';
                }
                else
                {
                    maior = '=';
                }
            }

            Console.WriteLine($"Area de X = {area1:F4}");
            Console.WriteLine($"Area de Y = {area2:F4}");
            Console.WriteLine($"Maior area: {maior}");
        }
    }
}
