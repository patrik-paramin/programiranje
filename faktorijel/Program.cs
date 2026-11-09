using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faktorijel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Faktorijel(5));
            //Console.WriteLine(Stanje(5, 1000, 100));
            Console.WriteLine(Zbroj(5));
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(Zbroj(i));
            }
        }
        //static int Faktorijel(int n)
        //{
        //    if (n == 0)
        //        return 1;
        //    return n * Faktorijel(n - 1);

        //}
        //static double Stanje(int n, double pocetno, double uplata)
        //{
        //    if (n == 0)
        //        return pocetno;
        //    return Stanje(n - 1, pocetno, uplata) + uplata;
        //}


        static int Zbroj(int n)
        {
            int zbroj = 0;
            if (n <= 0)
                return zbroj;
            return zbroj = zbroj + Zbroj(n - 1);
        }
    }

}
