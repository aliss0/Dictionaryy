using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaryy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> kullanicilar = new Dictionary<int, string>();
            kullanicilar.Add(10, "Ali Uygun");
            kullanicilar.Add(12, "Çağrı Dönmez");
            kullanicilar.Add(18, "Veli Özdemir");
            kullanicilar.Add(20, "Osman Demir");
            // dizinin elemanlarına erişme 
            Console.WriteLine("**** Elemanlara Erişim****");
            Console.WriteLine(kullanicilar[12]);
            Console.WriteLine("--------------------------------------");
            foreach (var item in kullanicilar)
                Console.WriteLine(item);

            //Count
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("**** Count ****");

            Console.WriteLine("--------------------------------------");
            Console.WriteLine(kullanicilar.Count);
            // Contains
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("**** Contains ****");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(kullanicilar.ContainsKey(12));
            Console.WriteLine(kullanicilar.ContainsValue("Ali Uygun"));
            // Remove 
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("**** Remove****");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(kullanicilar.Remove(12));
            foreach (var item in kullanicilar)
                Console.WriteLine(item.Value);
            // Keys
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("**** Keys****");
            Console.WriteLine("--------------------------------------");
            foreach (var item in kullanicilar.Keys)
                Console.WriteLine(item);
            // Values
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("**** Values****");
            Console.WriteLine("--------------------------------------");
            foreach (var item in kullanicilar.Values)
                Console.WriteLine(item);
            Console.ReadLine();
        }
    }
}
