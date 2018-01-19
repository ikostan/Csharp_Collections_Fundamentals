using System;
using System.Collections.Generic;

namespace CollectionsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introducing C# Collections:\n");

            ListDemo();
            ListDictionaries();

            Console.ReadKey();
        }

        private static void ListDemo()
        {
            Console.WriteLine("List sample: evry item has index\n");
            List<int> list = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }

            foreach (int num in list) {
                Console.Write(num + ", ");
            }

            Console.WriteLine();
        }

        private static void ListDictionaries()
        {
            Console.WriteLine("Dictionaries sample: evry item has unique key\n");

            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(534534556, "Alex");
            dict.Add(534545664, "Thor");
            dict.Add(124543455, "John");
            dict.Add(534111156, "Bill");
            dict.Add(112234556, "Sam");

            foreach (int key in dict.Keys) {
                Console.WriteLine($"key: {key}, value: {dict[key]}");
            }

            Console.WriteLine();
        }
    }
}
