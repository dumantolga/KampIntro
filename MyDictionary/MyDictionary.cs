using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class MyDictionary<K,V>
    {
        KeyValuePair<K,V> [] items;
        
        public MyDictionary()
        {
            items = new KeyValuePair<K, V>[0];
        }

        public void Add(K key,V value)
        {
            if (Control(key))
            {
                Configuration(key);
                items[items.Length - 1] = new KeyValuePair<K,V>(key, value);
            }
            else
            {
                Console.WriteLine("Girdiğiniz key değeri özel olmalı. Yani daha önceden eklenmiş bir key değerini tekrardan kullanamassınız.");
            }
        }

        public void ShowList()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

        }

        private void Configuration(K key)
        {
            KeyValuePair<K, V>[] tempArray = items;  // Geçici dizimizi oluşturduk
            items = new KeyValuePair<K, V>[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];  //Geçici dizideki elemanları alıp asıl dizimize gri koyduk.
            }

        }
        public bool Control(K key)
        {
            bool control = true;
            for(int i = 0; i < items.Length; i++)
            {
                if (items[i].Key.ToString() == key.ToString())
                {
                    control = false;
                }
            }
            return control;

        }


    }
}
