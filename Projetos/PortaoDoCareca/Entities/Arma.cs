using System;
using System.Collections.Generic;
using System.Text;

namespace PortaoDoCareca.Entities
{
    class Arma : ItemJogo
    {
        public double Dano { get; private set; }

        public Arma(int id, string name, double dano) : base(id, name)
        {
            Dano = dano;
        }


    }
}
