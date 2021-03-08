
using System;

namespace DegerVeReferansTipleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ?? sayi1'in cevabı 30'dur.
            Console.WriteLine(sayi1);
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[1] = 999;
            Console.WriteLine(sayilar1[0]);
            //sayilar1[0] ?? sayilar1'in cevabı 999'dur.
            //*** sayısal veri tipleri (int, decimal, float, double, boolen) değer tipidir. Fakat array, class, interface referans tip olarak karşımıza çıkar.
        }
    }
}
