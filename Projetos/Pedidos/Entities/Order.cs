using System;
using System.Collections.Generic;
using System.Text;

namespace Pedidos.Entities
{
    internal class Order
    {
        public DateTime Moment = DateTime.Now;
        public OrderStatus Status { get; private set; }
        public List<OrderItem> Itens = new List<OrderItem>();
        public Client Client { get; set; }

        public Order()
        {
        }

        public Order(OrderStatus status, Client client)
        {
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem Iten)
        {
            Itens.Add(Iten);
        }

        public void RemoveItem(OrderItem Iten)
        {
            Itens.Remove(Iten);
        }

        public double Total()
        {
            int i;
            double total = 0;

            for (i = 0; i < Itens.Count; i++)
            {
                total = total + Itens[i].SubTotal();
            }

            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Order Summary:");
            sb.AppendLine($"Order moment: {Moment}");
            sb.AppendLine($"Order status: {Status.ToString()}");
            sb.AppendLine($"Client: {Client.Name} ({Client.Birthday:dd/MM/yyyy}) - {Client.Email}");
            sb.AppendLine("Order items:");

            foreach (OrderItem item in Itens)
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine($"Total Price: ${Total():F2}");

            return sb.ToString();
        }
    }
}
