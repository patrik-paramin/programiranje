using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Zbroji(2, 3));
            //Console.WriteLine(Zbroji(2.5, 3.1));
            //Console.WriteLine(Zbroji(1, 2, 3));

            int[] ocjene = { 5, 4, 3, 5, 2 };
            Console.WriteLine(ZbrojElemenata(ocjene));
            Console.WriteLine(ZbrojElemenata(ocjene));

        }
        static int Zbroji(int a, int b)
        {
            return a + b;
        }
        static double Zbroji(double a, double b)
        {
            return a + b;
        }
        static int Zbroji(int a, int b, int c)
        { 
            return a + b + c;
        }
      static int ZbrojElemenata(int[] brojevi)
        {
            int zbroj = 0;
            for(int i=0; i<brojevi.Length;i++)
            {
                zbroj += brojevi[i];
                brojevi[i]++;
            }
                
            return zbroj;
        }
           
    }
}
