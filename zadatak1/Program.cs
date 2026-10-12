using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Prosjek(3, 4));
            Console.WriteLine(Prosjek(2, 3, 4));
            double[] ocjene = { 5, 4, 3, 5, 2 };
            Console.WriteLine(Prosjek(ocjene));

        }
        static double Prosjek(double a, double b)
        {
            double prosjek = (a + b) / 2;
            return prosjek;
        }
        static double Prosjek(double a, double b, double c)
        {
            double prosjek = (a + b + c) / 3;
            return prosjek;
        }
        static double Prosjek(double[] brojevi)
        {
            double zbroj = 0;
            for (int i = 0; i < brojevi.Length; i++) 
            {
                zbroj += brojevi[i];
                brojevi[i]++;

            }
            double prosjek = zbroj / brojevi.Length;
            return prosjek;


        }
    }
}
