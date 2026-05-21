using System;
using System.Collections.Generic;
using System.Text;

namespace mercado.Entites
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; protected set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufacturedate) : base(name, price)
        {
            ManufactureDate = manufacturedate;
        }

        public override string PriceTag()
        {
            return $"{Name} (Used) $ {Price:F2} (Manufacture date: {ManufactureDate})";
        }
    }
}
