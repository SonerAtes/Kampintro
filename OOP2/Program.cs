using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Müşteri1 Soner ATEŞ
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Soner";
            musteri1.Soyad = "ATEŞ";
            musteri1.TcNo = "12345678901";

            //Tüzel Müşteri ATEŞ Pazarlama

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "53243";
            musteri2.SirketAdi = "ATEŞ Pazarlama";
            musteri2.VergiNo = "1234567890";

            Console.WriteLine("Id = " + musteri2.Id + "Müşteri No = " + musteri2.MusteriNo + "Şirket Adı = " + musteri2.SirketAdi);


            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID 

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager= new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);



        }
    }
}
