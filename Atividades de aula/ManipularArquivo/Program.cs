using ManipularArquivo.Entites;
using System;
using System.IO;
using System.Globalization;

namespace ManipularArquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path;

            Console.WriteLine("Digite o caminho do arquivo: ");
            path = Console.ReadLine();

            try
            {
                string[] lines = File.ReadAllLines(path);

                string DirectoryPath, TargetFolderPath, TargeFilePath;

                DirectoryPath = Path.GetDirectoryName(path);
                TargetFolderPath = DirectoryPath + @"\out";
                TargeFilePath = TargetFolderPath + @"\summary.csv";

                Directory.CreateDirectory(TargetFolderPath);

                using(StreamWriter arquivo = File.AppendText(TargeFilePath))
                {
                    foreach(string line in lines)
                    {
                        string[] field = line.Split(',');

                        string nome;
                        double preco;
                        int quantidade;

                        nome = field[0];
                        preco = double.Parse(field[1], CultureInfo.InvariantCulture);
                        quantidade = int.Parse(field[2]);

                        Items produtos = new Items(nome, preco, quantidade);

                        arquivo.WriteLine($"{produtos.Nome},{produtos.Total().ToString("F2", CultureInfo.InvariantCulture)}");
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("Um erro aconteceu:");
                Console.WriteLine(e.Message);
            }
        }
    }
}