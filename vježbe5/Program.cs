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
        static int a = 0;
        static int b = 0;
        const double PDV = 0.25;
        static double sirina = 4, visina = 2;
        static int tekuciZbroj = 0;
        static int brojacPosjeta = 0;
        static double stanjeRacuna = 100;
        static string poruka = "Globalna (static) varijabla";
        static List<int> rezultati = new List<int>();
        static int zad1()
        {
            a = a + 1;
            return a;
        }
        static int zad2()
        {
            return a + b;
        }
        static double IzracunajPDV(double iznos)
        {
            return iznos * (1 + PDV);
        }
        static void Zad3()
        {
            Console.Write("Unesi cijenu bez PDV-om: ");
            double cijena = double.Parse(Console.ReadLine());
            Console.WriteLine("Cijena s PDV-om je: " + IzracunajPDV(cijena));
        }
        static double Opseg() { return 2 * (sirina + visina); }
        static double Povrsina() { return sirina * visina; }
        static void zad4()
        {
            Console.WriteLine("Širina: " + sirina + ", Visina: " + visina);
            Console.WriteLine("Opseg: " + Opseg());
            Console.WriteLine("Površina: " + Povrsina());

        }
        static void Dodaj(int x) { tekuciZbroj += x; }
        static void zad5()
        {
            Console.Write("Unesi broj za dodati: ");
            int broj = int.Parse(Console.ReadLine());
            Dodaj(broj);
            Console.WriteLine("Trenutni zbroj je: " + tekuciZbroj);
            
        }
        static void Posjet()
        {
            brojacPosjeta++;
            Console.WriteLine("Ovo je posjet broj " + brojacPosjeta);
        }
        static void zad6()
        {
            Posjet();
            
        }
        static void Uplati(double iznos) { stanjeRacuna += iznos; }
        static void Isplati(double iznos)
        {
            if (iznos > stanjeRacuna)
                Console.WriteLine("Greška: Nema dovoljno novca na računu!");
            else
                stanjeRacuna -= iznos;
        }
        static void zad7()
        {
            Console.WriteLine("Trenutno stanje: " + stanjeRacuna);
            Console.WriteLine("1. Uplata | 2. Isplata");
            int opcija = int.Parse(Console.ReadLine());
            Console.Write("Unesi iznos: ");
            double iznos = double.Parse(Console.ReadLine());

            if (opcija == 1) Uplati(iznos);
            else if (opcija == 2) Isplati(iznos);

            Console.WriteLine("Novo stanje: " + stanjeRacuna);
            
        }
        static void zad8()
        {
           
            string poruka = "Lokalna varijabla unutar metode";

            Console.WriteLine("Ispis lokalne: " + poruka);
            Console.WriteLine("Ispis globalne preko klase: " + Program.poruka);
          
        }
        static void DodajUListu(int r) { rezultati.Add(r); }
        static double Prosjek()
        {
            if (rezultati.Count == 0) return 0;
            double zbroj = 0;
            for (int i = 0; i < rezultati.Count; i++) zbroj += rezultati[i];
            return zbroj / rezultati.Count;
        }
        static void zad9()
        {
            Console.Write("Unesi cijeli broj u listu: ");
            int r = int.Parse(Console.ReadLine());
            DodajUListu(r);
            Console.WriteLine("Trenutni prosjek: " + Prosjek());
            
        }
    }
}
