using System;
using System.Collections.Generic;
using System.Text;

namespace ControleEmpresa.Entities
{
    internal class OutSourcedEmployee : Employee
    {
        public double AdditionalCharge { get; private set;}
        
        public OutSourcedEmployee()
        {
        }

        public OutSourcedEmployee(string name, int hours, double valuePerHouser, double additionalCharge) : base(name, hours, valuePerHouser)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + (AdditionalCharge * 1.1);
        }
    }
}
