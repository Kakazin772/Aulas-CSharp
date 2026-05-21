using System;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Quarto[] hotel = new Quarto[9];
            int numquarto, i, n;
            string nome, email;

            Console.WriteLine("Quantos quartos serao alugados?");
            n = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.WriteLine($"Aluguel #{i + 1}");

                Console.Write("Nome: ");
                nome = Console.ReadLine();
                
                Console.Write("Email: ");
                email = Console.ReadLine();

                Console.Write("Quarto: ");
                numquarto = int.Parse(Console.ReadLine());

                hotel[numquarto] = new Quarto{NomeInquilino = nome, EmailInquilino = email};
            }

            Console.WriteLine("Quartos Ocupados:");

            for (i = 0; i < 9; i++)
            {
                if (hotel[i] != null)
                {
                    Console.WriteLine($"{i}: {hotel[i].NomeInquilino}, {hotel[i].EmailInquilino}");
                }
            }
        }
    }
}