using System;
using System.Collections.Generic;
using System.Text;

namespace ManipularArquivo.Entites
{
    internal class Items
    {
        public string Nome { get; private set; }
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Items()
        {
        }

        public Items(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double Total()
        {
            return Preco * Quantidade;
        }
    }
}
