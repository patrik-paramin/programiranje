using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vježbe5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string izbor = "";
            do
            {
                for (int i = 1; i < 9; i++)
                {
                    Console.WriteLine(i.ToString() + ". Zadatak");
                }
                Console.WriteLine("0 izlaz");
                izbor = Console.ReadLine();
                switch (izbor)
                {
                    case "1":
                        zad1();
                        zad1();
                        zad1();
                        zad1();
                        Console.WriteLine("pozvana je: " + zad1());
                        break;
                    case "2":
                        Console.WriteLine("Unesi dva broja: ");
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Zbroj: " + zad2());
                        break;
                    case "3":
                        zad3();
                        break;
                        //case "4":
                        //    zad4();
                        //    break;
                        //case "5":
                        //    zad5();
                        //    break;
                        //case "6":
                        //    zad6();
                        //    break;
                        //case "7":
                        //    zad7();
                        //    break;
                        //case "8":
                        //    zad8();
                        //    break;
                        //    Console.WriteLine("nista nije odabrano");
                        //    break;
                }
            }
            while (izbor != "0");
        }
        static int a = 0;
        static int b = 0;
        static int zad1()
        {
            a = a + 1;
            return a;
        }
        static int zad2()
        {
            return a + b;
        }
        static int zad3()
        {

        }
    }
}
