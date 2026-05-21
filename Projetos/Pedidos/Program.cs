using System;
using Pedidos.Entities;
using System.Globalization;

namespace Pedidos
{
    class Program
    {
        static void Main(string[] args)
        {
            Order pedido = new Order();
            DateTime dataaniversario;
            OrderStatus status;
            Client client;

            string name, email, aniversario;
            int qnt, i;

            Console.WriteLine("Enter Client Data:");
           
            Console.Write("Name: ");
            name = Console.ReadLine();

            Console.Write("Email: ");
            email = Console.ReadLine();

            Console.Write("Birth Date (DD/MM/YYYY): ");
            aniversario = Console.ReadLine();

            dataaniversario = DateTime.ParseExact(aniversario, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            client = new Client(name, email, dataaniversario);

            Console.WriteLine("Enter order Data");
            
            Console.Write("Status: ");
            status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Console.Write("How many items to this order?: ");
            qnt = int.Parse(Console.ReadLine());

            pedido = new Order(status, client);

            for (i = 0; i < qnt; i++)
            {
                int itemqnt;
                string nameproduct;
                double price;

                Product product;
                OrderItem order;
                
                Console.WriteLine($"Enter #{i + 1} item data:");
                
                Console.Write("Product Name: ");
                nameproduct = Console.ReadLine();

                Console.Write("Product Price: ");
                price = double.Parse(Console.ReadLine());

                Console.Write("Quantity: ");
                itemqnt = int.Parse(Console.ReadLine());

                product = new Product(nameproduct, price);
                order = new OrderItem(itemqnt, price, product);

                pedido.AddItem(order);
            }

            Console.WriteLine(pedido);
        }
    }
}