using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Entites
{
    internal class PessoaFisica : Contribuintes
    {
        public double Saude { get; set; }

        public PessoaFisica(string nome, double rendaanual, double saude) : base(nome, rendaanual)
        {
            Saude = saude;
        }

        public override double Imposto()
        {
            double imposto;

            if (RendaAnual < 20000)
            {
                imposto = RendaAnual * 0.15;
            }
            else
            {
                imposto = RendaAnual * 0.25;
            }

            if (Saude > 0)
            {
                imposto = imposto - (Saude * 0.50);
            }

            return imposto;
        }
    }
}
