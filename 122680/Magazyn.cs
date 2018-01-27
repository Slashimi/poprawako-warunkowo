using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _122680
{
    class Magazyn
    {
        protected string adres;
        static string nazwa;
        public bool karta;
        private int iloscTowarow;
        public Magazyn() { }
        public void ustawAdres(string adres)
        {
            this.adres = adres;
        }
        public void karee(bool karta)
        {
            this.karta = karta;
        }
        public void ilTow(int lkk)
        {
            this.iloscTowarow = lkk;
        }
        public void ustawnazwe(string nazwaa)
        {
            Magazyn.nazwa = nazwaa;
        }


    }
}
