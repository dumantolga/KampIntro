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
        }
    }
}