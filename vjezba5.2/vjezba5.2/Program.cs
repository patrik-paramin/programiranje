using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezba5._2
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
                        break;
                    case "2":
                        zad2();
                        break;
                    case "3":
                        zad3();
                        break;
                    case "4":
                        zad4();
                        break;
                    case "5":
                        zad5();
                        break;
                    case "6":
                        zad6();
                        break;
                    case "7":
                        zad7();
                        break;
                    case "8":
                        zad8();
                        break;
                    case "9":
                        zad9();
                        break;
                        Console.WriteLine("nista nije odabrano");
                        break;
                }
            }
            while (izbor != "0");
        }
        static int Zbroji(int a, int b)
        {
            return a + b;
        }

        static int Zbroji(int a, int b, int c)
        {
            return a + b + c;
        }

        static void zad1()
        {
            Console.WriteLine("Zbroj 2 i 3 je: " + Zbroji(2, 3));
            Console.WriteLine("Zbroj 2, 3 i 4 je: " + Zbroji(2, 3, 4));
            
        }
        static void IspisiVrijednost(int x)
        {
            Console.WriteLine("Cijeli broj: " + x);
        }

        static void IspisiVrijednost(string s)
        {
            Console.WriteLine("Tekstualni niz: " + s);
        }

        static void zad2()
        {
            IspisiVrijednost(100);
            IspisiVrijednost("Pozdrav iz metode!");
           
        }
        static double Povrsina(double a) // Kvadrat
        {
            return a * a;
        }

        static double Povrsina(double a, double b) // Pravokutnik
        {
            return a * b;
        }

        static void zad3()
        {
            Console.WriteLine("Površina kvadrata (stranica 5): " + Povrsina(5));
            Console.WriteLine("Površina pravokutnika (4 i 6): " + Povrsina(4, 6));
            
        }
        static int Zbroj(int[] polje)
        {
            int s = 0;
            for (int i = 0; i < polje.Length; i++)
            {
                s += polje[i];
            }
            return s;
        }

        static void zad4()
        {
            int[] p = { 2, 4, 6, 8 };
            Console.WriteLine("Elementi polja: 2, 4, 6, 8");
            Console.WriteLine("Zbroj elemenata je: " + Zbroj(p));
            
        }
        static int Najveci(int[] polje)
        {
            int max = polje[0];
            for (int i = 1; i < polje.Length; i++)
            {
                if (polje[i] > max)
                {
                    max = polje[i];
                }
            }
            return max;
        }

        static void zad5()
        {
            int[] p = { 12, 45, 7, 89, 23 };
            Console.WriteLine("Elementi polja: 12, 45, 7, 89, 23");
            Console.WriteLine("Najveći element je: " + Najveci(p));
            
        }
        static double Prosjek(int[] polje)
        {
            double zbroj = 0;
            for (int i = 0; i < polje.Length; i++)
            {
                zbroj += polje[i]; // Pretvaramo u decimalni broj tijekom zbrajanja
            }
            return zbroj / polje.Length;
        }

        static void zad6()
        {
            int[] p = { 3, 4, 7 };
            Console.WriteLine("Elementi polja: 3, 4, 7");
            Console.WriteLine("Prosjek je: " + Prosjek(p));
            
        }
        static int Prebroji(int[] polje, int x)
        {
            int brojac = 0;
            for (int i = 0; i < polje.Length; i++)
            {
                if (polje[i] == x)
                {
                    brojac++;
                }
            }
            return brojac;
        }

        static void zad7()
        {
            int[] p = { 5, 2, 5, 8, 5, 1 };
            int trazeni = 5;
            Console.WriteLine("Elementi polja: 5, 2, 5, 8, 5, 1");
            Console.WriteLine("Broj " + trazeni + " se ponavlja: " + Prebroji(p, trazeni) + " puta.");
            
        }
        static int[] Obrni(int[] polje)
        {
            int[] novo = new int[polje.Length];
            for (int i = 0; i < polje.Length; i++)
            {
                novo[i] = polje[polje.Length - 1 - i];
            }
            return novo;
        }

        static void zad8()
        {
            int[] p = { 1, 2, 3, 4, 5 };
            int[] obrnuto = Obrni(p);
            Console.WriteLine("Originalno polje: 1, 2, 3, 4, 5");
            Console.Write("Obrnuto polje: ");
            for (int i = 0; i < obrnuto.Length; i++)
            {
                Console.Write(obrnuto[i] + " ");
            }
            Console.WriteLine();
            
        }
        static int Max(int[] polje)
        {
            int m = polje[0];
            for (int i = 1; i < polje.Length; i++)
            {
                if (polje[i] > m) m = polje[i];
            }
            return m;
        }

        static double Max(double[] polje)
        {
            double m = polje[0];
            for (int i = 1; i < polje.Length; i++)
            {
                if (polje[i] > m) m = polje[i];
            }
            return m;
        }

        static void zad9()
        {
            int[] pInt = { 10, 50, 20 };
            double[] pDouble = { 3.14, 9.81, 2.71 };

            Console.WriteLine("Max iz int polja: " + Max(pInt));
            Console.WriteLine("Max iz double polja: " + Max(pDouble));
            
        }
        static void Ispisi(int[] polje)
        {
            for (int i = 0; i < polje.Length; i++)
            {
                Console.Write(polje[i] + " ");
            }
            Console.WriteLine();
        }

        static void Ispisi(string[] polje)
        {
            for (int i = 0; i < polje.Length; i++)
            {
                Console.Write(polje[i] + " ");
            }
            Console.WriteLine();
        }

        static void zad10()
        {
            int[] brojevi = { 10, 20, 30, 40 };
            string[] rijeci = { "Ana", "voli", "Milovanu" };

            Console.Write("Ipis int polja: ");
            Ispisi(brojevi);

            Console.Write("Ispis string polja: ");
            Ispisi(rijeci);

            
        }
    }
}
