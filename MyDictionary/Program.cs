using System;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Adana");
            myDictionary.Add(6, "Ankara");
            myDictionary.Add(31, "Antakya");
            myDictionary.Add(34, "İstanbul");


            myDictionary.ShowList();
            Console.WriteLine();


        }
    }
}
