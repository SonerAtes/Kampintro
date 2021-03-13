using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Gerçek Müşteri = Individual
    //Miras - Inheritance
    //Gerçek Müşteri bir Müşteridir.
    class GercekMusteri:Musteri
    {
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyad { get; set; }
    }
}
