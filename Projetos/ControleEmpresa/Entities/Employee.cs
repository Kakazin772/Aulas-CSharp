using System;
using System.Collections.Generic;
using System.Text;

namespace ControleEmpresa.Entities
{
    internal class Employee
    {
        public string Name { get; private set; }
        public int Hours { get; set; }
        public double ValuePerHouser { get; private set; }

        public Employee()
        {
        }

        public Employee(string name, int hours, double valuePerHouser)
        {
            Name = name;
            Hours = hours;
            ValuePerHouser = valuePerHouser;
        }

        public virtual double Payment()
        {
            return Hours * ValuePerHouser;
        }
    }
}
