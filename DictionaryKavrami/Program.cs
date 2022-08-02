using System;

namespace DictionaryKavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            
            1) Dictionary sınıfı ,  içinde sizin belirleyeceğiniz bir key e uygun olarak değer saklama zorunluluğu var.
            
            2) Key türünü belirtmek şart ( string, int vs...)
            
             */

            Dictionary<string, int> isim_yas = new Dictionary<string, int>();
            
            //veri ekliyoruz.
            
            isim_yas.Add("Tolga", 25);
            isim_yas.Add("Tuncay", 23);
            isim_yas.Add("Emre", 11);

            foreach (var eklenenler in isim_yas)
            {
                Console.WriteLine(eklenenler);
            }

            //değer sayma özelliği

            var say = isim_yas.Count;
            Console.WriteLine();
            Console.WriteLine("Dictionary listemizdeki eleman sayısı  " + say);

            //silme işlemi

            isim_yas.Remove("Emre");
            Console.WriteLine();

            foreach (var eklenenler in isim_yas)
            {
                Console.WriteLine(eklenenler);
            }

            Console.WriteLine();

            Dictionary<int,string> plaka_il = new Dictionary<int,string>();
            plaka_il.Add(01, "Adana");
            plaka_il.Add(06, "Ankara");
            plaka_il.Add(31, "Antakya");
            plaka_il.Add(34, "İstanbul");

            foreach (var item in plaka_il)
            {
                Console.WriteLine(item);
            }

        }
    }
}