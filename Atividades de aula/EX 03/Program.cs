using System;

namespace EX_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            int qnt;

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preco: ");
            p.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade em estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p);

            Console.Write("Digite o numero de produtos a ser adicionado no estoque: ");
            qnt = int.Parse(Console.ReadLine());
            p.AdicionarQuantidade(qnt);

            Console.WriteLine($"Dados atualizados: {p}");

            Console.Write("Digite o numero de produtos a ser removido no estoque: ");
            qnt = int.Parse(Console.ReadLine());
            p.RemoverQuantidade(qnt);

            Console.WriteLine($"Dados atualizados: {p}");
        }
    }
}