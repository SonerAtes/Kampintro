using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convetion
        //syntax
        public void Ekle(Urun urun)
        {
            //Bu sayfada yapılan her değişiklik Program.cs sayfasındaki Metotlarda görünecek veya değişecek.
            Console.WriteLine("Sepete Eklendi -" + urun.Adi);
        }
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Sepete Eklendi -" + urunAdi);
        }
    }
}
