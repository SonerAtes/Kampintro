using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Soner ATEŞ");

            Console.WriteLine(isimler.Lenght);

            isimler.Add("Soner");

            Console.WriteLine(isimler.Lenght);

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }

            Console.WriteLine("Hello World!");
        }
    }
}
