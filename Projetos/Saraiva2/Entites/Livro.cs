using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Saraiva2
{
    internal class Livro : Item, IEmprestravel
    {
        public string Autor { get; private set; }
        public int Paginas { get; private set; }
        
        private StatusLivro status = StatusLivro.Disponivel;

        public Livro(string titulo, int ano, string autor, int paginas) : base(titulo, ano)
        {
            Autor = autor;
            Paginas = paginas;
        }

        public void Emprestar()
        {
            if (status == StatusLivro.Emprestado)
            {
                throw new Exception("Livro já emprestado!");
            }

            status = StatusLivro.Emprestado;
        }

        public void Devolver()
        {
            status = StatusLivro.Disponivel;
        }

        public override void ExibirInfo()
        {
            Console.WriteLine($"Titulo: {Titulo}    Ano: {Ano}");
            Console.WriteLine($"Autor: {Autor}\nPaginas: {Paginas}\nStatus: {status}");
        }
    }
}
