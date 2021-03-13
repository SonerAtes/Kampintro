using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Tüzel Müşteri = Coorporate
    //Miras - Inheritance
    //Tüzel Müşteri bir Müşteridir.
    class TuzelMusteri:Musteri
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
