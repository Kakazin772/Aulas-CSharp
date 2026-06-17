using System;
using System.Collections.Generic;
using System.Text;

namespace LinQ
{
    class Funcionario
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public double Salario { get; private set; }
           
        public Funcionario()
        {
        }

        public Funcionario(string nome, string email, double salario)
        {
            Nome = nome;
            Email = email;
            Salario = salario;
        }
    }
}
