using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2; // 2 numara mobilya'ya karşılık geliyor.
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 34;

            Product product2 = new Product {Id = 2, CategoryId = 5, UnitsInStock = 36, ProductName = "Kalem", UnitPrice = 20};

            //PascalCase    //camelCase
            //case sensitive
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
            Console.WriteLine(product2.ProductName);

            


            //***int, double, bool...DEĞER TİPİ
            //***diziler, classlar, abstract classlar, interfaceler....REFERANS TİP
            //***ref - out keyword
        }
    }
}
