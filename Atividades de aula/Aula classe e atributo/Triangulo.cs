using System;

namespace Aula_classe_e_atributo
{
    internal class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double Area()
        {
            double p, area;

            p = (A + B + C) / 2;
            area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            return area;
        }
    }
}
