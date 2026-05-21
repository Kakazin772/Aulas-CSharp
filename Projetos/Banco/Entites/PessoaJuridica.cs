using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Entites
{
    internal class PessoaJuridica : Contribuintes
    {
        public int NumFuncionarios { get; set; }

        public PessoaJuridica(string nome, double rendaanual, int numFuncionarios) : base(nome, rendaanual)
        {
            NumFuncionarios = numFuncionarios;
        }

        public override double Imposto()
        {
            double imposto;

            if (NumFuncionarios > 10)
            {
                imposto = RendaAnual * 0.14;
            }
            else
            {
                imposto = RendaAnual * 0.16;
            }

            return imposto;
        }
    }
}
