using System;

namespace DictionaryDeneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> users = new MyDictionary<int, string>();

            users.Add(12, "Merve");
            users.Add(31, "Tolga");
            users.Add(79, "Betül");

            users.Print();
        }
    }
}