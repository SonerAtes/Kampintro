using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product //Product = Ürün
    {
        //prop (tab+tab) snippet demek

        //Id Ürünün  Numarası Demek
        public int Id { get; set; }
        //Hangi Kategoride Olduğunu Belirtiyor
        public int CategoryId { get; set; }
        //Ürünün İsmi
        public string ProductName { get; set; }
        //Ürünün Birim Fiyatı
        public double UnitPrice { get; set; }
        //Ürünün Stok Adedi
        public int UnitsInStock { get; set; }


        //CRUD - C : Creat (Eklemek) - R : Read (Okumak) - U : Update (Güncellemek) - D : Delete (Silmek)
    }
}
