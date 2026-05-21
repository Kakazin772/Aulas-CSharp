using System;
using System.Globalization;
using mercado.Entites;

namespace mercado
{
    class Program
    {
        static void Main(string[] args)
        {
            int nump, i;
            char resp;
            string name;
            double price;

            List<Product> produtos = new List<Product>();

            Console.Write("Enter the number of products: ");
            nump = int.Parse(Console.ReadLine());

            for (i = 0; i < nump; i++)
            {
                Console.WriteLine($"Product #{i} data:");

                Console.Write("Common, used or imported (c/u/i)? ");
                resp = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                name = Console.ReadLine();
                
                Console.Write("Price: ");
                price = double.Parse(Console.ReadLine());
                
                if (resp == 'c')
                {
                    produtos.Add(new Product(name, price));
                }
                else
                {
                    if (resp == 'u')
                    {
                        Console.Write("Manufacture Date: ");
                        DateTime manufacturedate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        produtos.Add(new UsedProduct(name, price, manufacturedate));
                    }
                    else
                    {
                        Console.Write("Custom fee: ");
                        double customfee = double.Parse(Console.ReadLine());
                        produtos.Add(new ImportedProduct(name, price, customfee));
                    }
                }
            }

            foreach(Product product in produtos)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}