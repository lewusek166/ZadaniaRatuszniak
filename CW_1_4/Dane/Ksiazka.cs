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
        private string text1;
        private string text2;
        private string text3;

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

        public Ksiazka(string text1, string text2, string text3)
        {
            this.text1 = text1;
            this.text2 = text2;
            this.text3 = text3;
        }

        public override string ToString()
        {
            return string.Format("{0} - \"{1}\"", Autor, Tytul);
        }
    }
}
