using System;
using Escola.Entites;

namespace Escola
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, id;

            HashSet<Student> students = new HashSet<Student>(); ;

            Console.WriteLine("How many students for course A?");
            n = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                id = int.Parse(Console.ReadLine());

                students.Add(new Student(id));
            }

            Console.WriteLine("How many students for course B?");
            n = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                id = int.Parse(Console.ReadLine());

                students.Add(new Student(id));
            }

            Console.WriteLine("How many students for course C?");
            n = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                id = int.Parse(Console.ReadLine());

                students.Add(new Student(id));
            }

            Console.WriteLine($"Total students: {students.Count}");
        }
    }
}