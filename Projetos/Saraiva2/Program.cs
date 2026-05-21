using System;
using System.Security.Cryptography.X509Certificates;

namespace Saraiva2
{
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();
            
            string path;
            char continuar = 's';

            Console.WriteLine("Digite o caminho do arquivo:");
            path = Console.ReadLine();

            using (StreamReader itens = new StreamReader(path))
            {
                while(!itens.EndOfStream)
                {
                    string[] lines = itens.ReadLine().Split(',');

                    if (lines[0] == "Livro")
                    {
                        Livro livro = new Livro(lines[1], int.Parse(lines[2]), lines[3], int.Parse(lines[4]));

                        biblioteca.Livros.Add(lines[1], livro);
                        biblioteca.Items.Add(livro);
                    }
                    else
                    {
                        biblioteca.Items.Add(new Revista(lines[1], int.Parse(lines[2]), lines[3]));
                    }
                }
            }

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Catalago:");

            foreach (Item item in biblioteca.Items)
            {
                item.ExibirInfo();
                Console.WriteLine();
            }

            Console.WriteLine("--------------------------------------------------");

            while(continuar == 's')
            {
                Console.WriteLine("Deseja pegar um livro emprestrado?");
                char resp = char.Parse(Console.ReadLine());

                if (resp == 'S')
                {
                    Console.WriteLine("Digite o nome do livro:");
                    string name = Console.ReadLine();

                    try
                    {
                        if (biblioteca.Livros.ContainsKey(name))
                        {
                            biblioteca.Livros[name].Emprestar();
                        }
                        else
                        {
                            Console.WriteLine("Livro não encontrado!");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Erro!: {ex.Message}");
                    }
                }

                Console.WriteLine("Deseja devolver um livro emprestrado?");
                resp = char.Parse(Console.ReadLine());

                if (resp == 'S')
                {
                    Console.WriteLine("Digite o nome do livro:");
                    string name = Console.ReadLine();

                    biblioteca.Livros[name].Devolver();
                }

                Console.WriteLine("Exibir Novamente o catalago?");
                resp = char.Parse(Console.ReadLine());

                if ( resp == 'S')
                {
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine("Catalago:");

                    foreach (Item item in biblioteca.Items)
                    {
                        item.ExibirInfo();
                        Console.WriteLine();
                    }

                    Console.WriteLine("--------------------------------------------------");
                }

                Console.WriteLine("Deseja Continuar?");
                continuar = char.Parse(Console.ReadLine());
            }
        }
    }
}