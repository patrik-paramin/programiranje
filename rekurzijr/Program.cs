using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace rekurzijr
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
                        Console.WriteLine(zad1(5));
                        break;
                    case "2":
                        Console.WriteLine(zad2(5));
                        break;
                    case "3":
                        
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
        static int zad1(int n)
        {
            if (n == 0);
            return 0;
            return zad1(n - 1) + n;
        }
        static int zad2(int n)
        {
            if (n == 0)
                return 0;
            return zad2(n - 1) + n;

        }
        static int zad3(int n)
        {
            if (n == 0)
                return 1;
            return zad3(n - 1) + 2 * n - 1;

        }
       static int zad4(int n)
        {
            if (n == 0)
                return 1;
            return zad4(n - 1) * n;
        }
    } 
