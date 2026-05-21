using System;
using System.Collections.Generic;
using System.Text;

namespace geometria.Entities
{
    internal class Retangle : Shape
    {
        public double With { get; set; }
        public double Height { get; set; }

        public Retangle(double with, double height, Color color) : base(color)
        {
            With = with;
            Height = height;
        }

        public override double Area()
        {
            return Height * With;
        }
    }
}
