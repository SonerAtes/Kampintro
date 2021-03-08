using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kursu";
            string kurs2 = "Programlanabilir Kumanda Devreleri";
            string kurs3 = "Mekatronik";

            //Böyle teker teker yazmak yerine array kullan.

            //array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yatiştirme Kursu", "Programlanabilir Kumanda Devreleri", "Mekatronik", "HTML", "CSS", "C#" };
            for(int i=0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For Bitti.");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa Sonu - Footer Alanı");
        }
    }
}
