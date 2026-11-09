using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponavljanje
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
                        Console.WriteLine("Unesi ime i prezime");
                        string ime= Console.ReadLine();
                        Console.WriteLine(ime.ToUpper());
                        Console.WriteLine("dužina " + ime.Length);
                        IspisiOkvir();
                        break;
                    //case "2":
                    //    zad2();
                    //    break;
                    //case "3":
                    //    zad3();
                    //    break;
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
                        Console.WriteLine("nista nije odabrano");
                        break;
                }
            }
            while (izbor != "0");
        }
        static void IspisiOkvir()
        {
            Console.WriteLine("=========================");
        }
    }
}
