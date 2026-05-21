using System;
using System.Collections.Generic;
using System.Text;

namespace Empregrado
{
    internal class Funcionario
    {
        private string _nome, _sobrenome;
        private double _salario;

        public Funcionario()
        {
            _nome = "";
            _sobrenome = "";
            _salario = 0;
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Sobrenome
        {
            get { return _sobrenome; }
            set { _sobrenome = value; }
        }

        public double Salario
        {
            get { return _salario; }
            set
            {
                if (value > 0)
                {
                    _salario = value;
                }
                else
                {
                    _salario = 0.0;
                }
            }
        }

        public double SalarioAnual()
        {
            return _salario * 12; 
        }
    }
}
