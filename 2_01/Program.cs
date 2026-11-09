using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tocka2D tocka = new Tocka2D();
            //tocka.X = 3.5;
            //tocka.Y = 4.2;
            //Console.WriteLine($"({tocka.X}, {tocka.Y})");

            //Pravokutnik p1 = new Pravokutnik { A = 4.0, B = 5.5 };
            //Pravokutnik p2 = new Pravokutnik { A = 2.0, B = 8.0 };
            //Console.WriteLine($"Prvi pravokutnik: A = {p1.A}, B = {p1.B}");
            //Console.WriteLine($"Drugi pravokutnik: A = {p2.A}, B = {p2.B}");

            //Osoba o1 = new Osoba();
            //Console.WriteLine("Unesite ime osobe:");
            //o1.Ime = Console.ReadLine();
            //Console.WriteLine("Unesite godine osobe:");
            //o1.Godine = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Osoba: {o1.Ime}, Godine: {o1.Godine}");

            //Krug k = new Krug();
            //k.Polumjer = 5.0;
            //Console.WriteLine($"Polumjer: {k.Polumjer}");
            //Console.WriteLine($"Površina: {k.Povrsina()}");


            Automobil[] voznipark = new Automobil[3];
            Automobil a1 = new Automobil();
            a1.Marka = "Toyota";
            a1.Model = "Corolla";
            a1.GodinaProizvodnje = 2015;
            a1.Kilometraza = 80000;
            voznipark[0] = a1;



        }
    }
}
