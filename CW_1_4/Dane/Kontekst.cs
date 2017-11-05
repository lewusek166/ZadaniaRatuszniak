using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dane
{
    public class Kontekst
    {
        private List<Ksiazka> kolekcjaKsiazek;

        public List<Ksiazka> KolekcjaKsiazek
        {
            get { return kolekcjaKsiazek; }
        }

        public Kontekst()
        {
            kolekcjaKsiazek = new List<Ksiazka>();
            ZaladujDane();
        }

        private void ZaladujDane()
        {
            this.DodajKsiazke("Pan Tadeusz", "Adam Mickiewicz", 800);
            this.DodajKsiazke("Agile. Programowanie zwinne", "Robert C. Martin", 700);
            this.DodajKsiazke("Czysty kod", "Robert C. Martin", 400);
        }

        private void DodajKsiazke(string tytul, string autor, int iloscStron)
        {
            this.kolekcjaKsiazek.Add(new Ksiazka(tytul, autor, iloscStron));
        }

        public void DodajKsiazke(Ksiazka ksiazka)
        {
            if (ksiazka != null)
                this.kolekcjaKsiazek.Add(ksiazka);
        }

        public void UsunKsiazke(Ksiazka ksiazka)
        {
            if (ksiazka != null)
                this.kolekcjaKsiazek.Remove(ksiazka);
        }
    }
}
