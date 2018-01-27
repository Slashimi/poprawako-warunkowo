using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _122680
{
    abstract class Produkt
    {
        private string Nazwa;

        public Produkt(string nazwa)
        {
            Nazwa = nazwa;
        }

        public abstract bool Kup(int param);
 
        
    }
}
