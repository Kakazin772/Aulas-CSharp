using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Saraiva2
{
    class Revista : Item
    {
        public string Edicao { get; set; }

        public Revista(string titulo, int ano, string edicao) : base(titulo, ano)
        {
            Edicao = edicao;
        }

        public override void ExibirInfo()
        {
            Console.WriteLine($"Titulo: {Titulo}    Ano: {Ano}");
            Console.WriteLine($"Edicao: {Edicao}");
        }
    }
}
