using System;
using System.Collections.Generic;
using System.Text;

namespace mercado.Entites
{
    internal class ImportedProduct : Product
    {
        public double CustomFee { get; protected set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customFee) : base(name, price)
        {
            CustomFee = customFee;
        }

        public double TotalPrice()
        {
            return Price + CustomFee;
        }

        public override string PriceTag()
        {
            return $"{Name} $ {TotalPrice():F2} (Custom Fee: $ {CustomFee})";
        }
    }
}
