using System;
using System.Collections.Generic;
using System.Text;

namespace Saraiva2
{
    abstract class Item
    {
        public string Titulo { get; set; }
        public int Ano { get; set; }

        public Item(string titulo, int ano) 
        {
            Titulo = titulo;
            Ano = ano;
        }

        public abstract void ExibirInfo();
    }
}
