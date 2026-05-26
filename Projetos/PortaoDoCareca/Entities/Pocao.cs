using PortaoDoCareca.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace PortaoDoCareca.Entities
{
    class Pocao : ItemJogo, IComerciavel
    {
        public int Cura { get; set; }
        private int _quantidade;

        public Pocao(int id, string name, Raridade raridade, int cura) : base(id, name, raridade)
        {
            Cura = cura;
        }

        public override void UsarItem()
        {
            if (_quantidade <= 0)
            {
                throw new Exception("Voce nao possui mais poções");
            }

            Console.WriteLine($"Voce Curou {Cura} pontos de vida");

            _quantidade = _quantidade - 1;
        }

        public double ValorVenda()
        {
            if (RaridadeItem == Raridade.Comum)
            {
                return 1.0;
            }

            if (RaridadeItem == Raridade.Raro)
            {
                return 2.5;
            }

            if (RaridadeItem == Raridade.Epico)
            {
                return 3.0;
            }

            if (RaridadeItem == Raridade.Lendario)
            {
                return 4.5;
            }

            return 0;
        }

        public void Vender()
        {
            _quantidade--;
        }
    }
}
