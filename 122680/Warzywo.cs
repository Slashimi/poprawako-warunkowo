using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _122680
{
    class Warzywo : Produkt
    {
        private float Waga;

        public Warzywo(string nazwa, float waga)
            : base(nazwa)
        {
            Waga = waga;
        }

            

        override public bool Kup(int lika)
        {
            if (lika %2==0)
            {
                return true;
            }
           else
            {
                return false;
            }
        }
    }
}
