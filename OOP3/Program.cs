using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKredisiManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService(), new DatabaseLoggerService()};

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKrediManager, loggers);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };
            //basvuruManager.KrediOnBilgilendirmesi(krediler);

           // IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
           // ihtiyacKrediManager.Hesapla();

           //TasitKrediManager tasitKrediManager = new TasitKrediManager();
           // tasitKrediManager.Hesapla();

           // KonutKrediManager konutKrediManager = new KonutKrediManager();
           // konutKrediManager.Hesapla();

            //IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();  
            //ihtiyacKrediManager.Hesapla();

            //***Bu Şekilde de Sonuç Verir. ve Sonuç Hepsinde Aynı Olur.
            //*** Bunun sebebi interfacelerin intlament ettikleri classın referans elemanını tutmalarıdır.
        }
    }
}
