using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Entites
{
    abstract class Contribuintes
    {
        public string Nome { get; set; }
        public double RendaAnual { get; private set; }

        public Contribuintes(string nome, double rendaanual)
        {
            Nome = nome;
            RendaAnual = rendaanual;
        }

        abstract public double Imposto();
    }
}
