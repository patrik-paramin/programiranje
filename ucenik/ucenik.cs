using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucenik
{
    internal class ucenik
    {
        public string ime;
        public string prezime;
        public int razred;
        public double prosjek;

        public void Ispis()
        {
            
            Console.WriteLine($"Učenik: {ime} {prezime}, prosjek: {prosjek}, razred: {razred} ");
        }
        public void Ispis(string Ime)
        {
            this.ime = Ime;
            Ispis();
        }




    }
}
