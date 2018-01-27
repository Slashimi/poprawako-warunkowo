using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _122680
{
    class Tablet : IElektronika, IComparable<Tablet>
    {
        private string model;
        public Tablet(string MODEL)
        {
            this.model = MODEL;
        }
        public int Wlacz(int liczbaaa)
        {
            return liczbaaa;
        }
        public void Wylacz(bool ok)
        {
            if (ok == true)
            {
                Console.WriteLine("true");
            }
        }
        public void pokazNazwe()
        {
            Console.WriteLine(model);
        }
        public int CompareTo(Tablet other)
        {
            return this.model.CompareTo(other.model);
        }
    }
}
