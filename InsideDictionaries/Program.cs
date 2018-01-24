using System;
using System.Collections.Generic;

namespace InsideDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inside Dictionaries:\n");

            sampleDictionary();

            Console.WriteLine("Please enter any key to continue...");
            Console.ReadKey();
        }

        //Basic sample
        private static void sampleDictionary()
        {
            var primeMinisters = new Dictionary<string, PrimeMinister>
            {
                {"JC", new PrimeMinister("James", "Callaghan", 1976)},
                {"MT", new PrimeMinister("Margaret", "Thatcher", 1979)},
                {"TB", new PrimeMinister("Tony", "Blair", 1997)}
            };

            //Dictionary object (tKey, tValue)
            foreach (var pm in primeMinisters)
            {
                Console.WriteLine(string.Format("{0}: {1}",pm.Key, pm.Value));
            }

            Console.WriteLine();

            //key-value pairs
            foreach (string pm in primeMinisters.Keys)
            {
                Console.WriteLine(primeMinisters.GetValueOrDefault(pm, null));
            }

            Console.WriteLine();

            //Keys only
            foreach (string pm in primeMinisters.Keys)
            {
                Console.WriteLine(pm);
            }

            Console.WriteLine();

            //Values only
            foreach (PrimeMinister pm in primeMinisters.Values)
            {
                Console.WriteLine(pm);
            }

            Console.WriteLine();
        }

        //End of Class
    }
}
