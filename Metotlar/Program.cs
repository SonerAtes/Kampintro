using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 3;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 3;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Portakal";
            urun2.Fiyati = 5;
            urun2.Aciklama = "Sıkmalık Portakal";

            Urun[] urunler = new Urun[] { urun1, urun2 };
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------------------");
            }

            Console.WriteLine("---------------Metotlar------------------");

            //instance - örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Portakal", "Sıkmalık Portakal", 5, 1000);
            sepetManager.Ekle2("Elma", "Amasya Elması", 3, 1500);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 1.5, 1000);
        }
    }
}


//*** Do Not Repeat Yourself - DRY - Clean Code - Best Practise
