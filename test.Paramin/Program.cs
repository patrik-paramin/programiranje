using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Paramin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int izbor;
            do
            {
                Console.WriteLine("======= TEST 1 - PRAKTIČNI DIO ======");
                Console.WriteLine("1 - prvi zadatak");
                Console.WriteLine("2 - drugi zadatak");
                Console.WriteLine("3 - treći zadatak");
                Console.WriteLine("Odabir: ");

                izbor = int.Parse(Console.ReadLine());

                switch (izbor)
                {
                    case 1:
                        obradikrug();
                    break;
                    case 2:
                        obradatekst();
                    break;
                    case 3:
                        //zad3();
                     break;
                    case 0:
                        Console.WriteLine("Izlaz iz programa");
                        break;
                    default:
                        Console.WriteLine("nepoznat odabir");
                        break;
                }
                Console.WriteLine();
            }
               while (izbor != 0);
        }

        static void obradikrug()
        {
            Console.WriteLine("Unesite polumjer r: ");
            double r = double.Parse(Console.ReadLine());

            if(r <= 0)
            {
                Console.WriteLine("polumjer mora biti pozitivan broj ");
                return;
            }
            double opseg = 2 * Math.PI * r;
            double povrsina = Math.PI * r;

            Console.WriteLine("Opseg približno " + Math.Round(opseg, 2) + "površina približno " + Math.Round(povrsina, 2));
        }

        static void obradatekst()
        {
            Console.WriteLine("Unesite riječ: ");
            string tekst = Console.ReadLine();

            int brojznakova = tekst.Length;
            string velikaslova = tekst.ToUpper();

            string sadrziA = "NE";
            if (tekst.Contains("a"))
            {
                sadrziA = "DA";
            }

            Console.WriteLine( brojznakova + " znakova:  \"" + velikaslova + "\"; sadrži a:" + sadrziA);

        }



    }
}
