using ControleEmpresa.Entities;
using System;

namespace ControleEmpresa
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empregados = new List<Employee>();

            int numfunc, horas, i;
            string nome;
            double valor;
            char resp;

            Console.Write("Enter the number of employees: ");
            numfunc = int.Parse(Console.ReadLine());

            for (i = 0; i < numfunc; i++)
            {
                Console.WriteLine($"Employee #{i + 1} data:");
                
                Console.Write("OutSourced? (y/n): ");
                resp = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                nome = Console.ReadLine();
                Console.Write("Hours: ");
                horas = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                valor = double.Parse(Console.ReadLine());

                if (resp == 'y')
                {
                    double additional;

                    Console.Write("Additional charge: ");
                    additional = double.Parse(Console.ReadLine());

                    empregados.Add(new OutSourcedEmployee(nome, horas, valor, additional));
                }
                else
                {
                    empregados.Add(new Employee(nome, horas, valor));
                }
            }

            Console.WriteLine("Paymentes:");

            for (i = 0; i < empregados.Count; i++)
            {
                Console.WriteLine($"{empregados[i].Name} - $ {empregados[i].Payment():F2}");
            }
        }
    }
}
