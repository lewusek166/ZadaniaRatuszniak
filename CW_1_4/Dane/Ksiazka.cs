using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dane
{
    public class Ksiazka
    {
        private string tytul;

        public string Tytul
        {
            get { return tytul; }
            set { tytul = value; }
        }

        private string autor;

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        private int iloscStron;

        public int IloscStron
        {
            get { return iloscStron; }
            set { iloscStron = value; }
        }

        public Ksiazka(string tytul, string autor, int iloscStron)
        {
            this.tytul = tytul;
            this.autor = autor;
            this.iloscStron = iloscStron;
        }

        public override string ToString()
        {
            return string.Format("{0} - \"{1}\"", Autor, Tytul);
        }
    }
}
