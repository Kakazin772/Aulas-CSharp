using System;
using System.Collections.Generic;
using System.Text;
using Contratos.Entities.Enum;

namespace Contratos.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public Workerlevel Level { get; set; }
        public double Salary { get; set; }
        public Departament Departament { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker ()
        {
        }

        public Worker (string name, Workerlevel level, double salary, Departament departament)
        {
            Name = name;
            Level = level;
            Salary = salary;
            Departament = departament;
        }

        public void AddContract (HourContract contract)
        {
            Contracts.Add(contract); 
        }

        public void RemoveContract (HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income (int year, int month)
        {
            double soma = Salary;

            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    soma = soma + contract.TotalValue();
                }
            }

            return soma;
        }

    }
}
