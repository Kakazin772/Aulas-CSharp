using System;
using System.Collections.Generic;
using System.Text;

namespace Lista
{
    internal class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public void AumentoSalario (int porcentagem)
        {
            Salario = Salario * (porcentagem / 100.0 + 1);
        }

        public override string ToString()
        {
            return $"{Id}, {Nome}, {Salario:F2}";
        }
    }
}
