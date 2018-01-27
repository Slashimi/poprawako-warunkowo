using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _122680
{
    class Program
    {
        static void Main(string[] args)
        {
            Tablet moja = new Tablet("MSDN");
            moja.Wlacz(12);
            moja.Wylacz(true);
            Queue<Tablet> kolejka = new Queue<Tablet>();
            kolejka.Enqueue(moja);
            kolejka.Enqueue(new Tablet("Padmi"));
            kolejka.Enqueue(new Tablet("MCWIN"));
            foreach (var element in kolejka)
            {
                element.pokazNazwe();
            }
            Console.ReadKey();
            //Tablet temp;
            //while (kolejka.Count> 0)
            //{
            //    temp = kolejka.Dequeue();
            //    temp.Wylacz(true);
            //}
            kolejka.Clear();
            List<Tablet> lista = new List<Tablet>();
            lista.Add(moja);
            lista.Add(new Tablet("PADMI"));
            lista.Add(new Tablet("MCWIN"));
            lista.Reverse();
            lista.Sort();
            //lista.Sort((a, b) => b.pokazNazwe().CompareTo(a.pokazNazwe()));
            List<int> l1 = new List<int>();
            l1.Add(123);
            l1.Add(4123);
            List<int> l2 = new List<int>();
            l2.Add(12412);
            l2.Add(15653);
            Dictionary<string, List<int>> slownik = new Dictionary<string, List<int>>();
            slownik.Add("jakies", l1);
            slownik.Add("inne", l2);
            List<Produkt> produkty = new List<Produkt>();
            produkty.Add(new Warzywo("Marchewka", 3.4F));
            produkty.Add(new Warzywo("Burak", 6.23F));
            produkty.Add(new Warzywo("Ziemniak", 22.09F));
            produkty.Add(new Warzywo("Brokuł", 0.22F));

            foreach (var prod in produkty)
            {
                Console.WriteLine(prod.Kup(12));
            }
            Owoc owoc = Owoc.AddOwoc();
            moja.pokazNazwe();
            Console.ReadKey();
            Magazyn Sklep = new Magazyn();
            Sklep.ustawAdres("Olsztyn");
            Sklep.karee(true);
            Sklep.ilTow(1234);
            Sklep.ustawnazwe("pokoik");



        }
    }
}
