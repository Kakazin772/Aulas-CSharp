using System;
using Banco.Entites;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;

            List<Contribuintes> contribuintes = new List<Contribuintes>();

            Console.Write("Digite o numero de pessoas que irao pagar a taxa: ");
            n = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                string nome;
                char resp;
                double rendaanual;

                Console.WriteLine($"Pagador num #{i + 1}");

                Console.Write("Pessoa fisica ou juridica? (f/j): ");
                resp = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                nome = Console.ReadLine();

                Console.Write("Renda Anual: ");
                rendaanual = double.Parse(Console.ReadLine());

                if (resp == 'f')
                {
                    double saude;

                    Console.Write("Gasto com saude: ");
                    saude = double.Parse(Console.ReadLine());

                    contribuintes.Add(new PessoaFisica(nome, rendaanual, saude));
                }
                else
                {
                    int numfunc;

                    Console.Write("Numeros de funcionarios: ");
                    numfunc = int.Parse(Console.ReadLine());

                    contribuintes.Add(new PessoaJuridica(nome, rendaanual, numfunc));
                }
            }

            double total = 0;

            Console.WriteLine("Taxas pagas:");

            foreach (Contribuintes pessoa in contribuintes)
            {
                Console.WriteLine($"{pessoa.Nome}: $ {pessoa.Imposto():F2}");

                total = total + pessoa.Imposto();
            }

            Console.WriteLine($"Total de taxas: $ {total:F2}");
        }
    }
}