using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    internal class Quarto
    {
        string _nomeInquilino, _emailInquilino;

        public string NomeInquilino
        {
            get { return _nomeInquilino; }
            set { _nomeInquilino = value; }
        }

        public string EmailInquilino
        {
            get { return _emailInquilino; }
            set { _emailInquilino = value; }
        }


    }
}
