using System;

namespace Struct_e_nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(), q = new Point();
            int? a = null, b = 1;
            int c, d;

            p.X = 1;
            p.Y = 1;

            q.X = p.X + 1;
            q.Y = p.Y + 1;

            c = a ?? 5;
            d = b ?? 0;

            Console.WriteLine(p);
            Console.WriteLine(q);
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}