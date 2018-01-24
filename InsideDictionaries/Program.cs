using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace InsideDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inside Dictionaries:\n");

            //sampleDictionary();
            //getValueByKey();
            //replaceValueByKey();
            //addNewValue();
            //removeValue();
            //keyComparison();
            //sampleReadOnlyDict();
            //sampleSortedDict();
            //sampleSortedList();
            sampleKeyedCollection();

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

        //Basic sample
        private static void getValueByKey()
        {
            var primeMinisters = new Dictionary<string, PrimeMinister>
            {
                {"JC", new PrimeMinister("James", "Callaghan", 1976)},
                {"MT", new PrimeMinister("Margaret", "Thatcher", 1979)},
                {"TB", new PrimeMinister("Tony", "Blair", 1997)}
            };

            //Does not handle exception
            PrimeMinister tb = primeMinisters["TB"];
            Console.WriteLine(tb);

            //Handle exception
            PrimeMinister mt = primeMinisters.GetValueOrDefault("IT", null);
            Console.WriteLine(mt);

            Console.WriteLine();
        }

        //Basic sample
        private static void replaceValueByKey()
        {
            var primeMinisters = new Dictionary<string, PrimeMinister>
            {
                {"JC", new PrimeMinister("James", "Callaghan", 1976)},
                {"MT", new PrimeMinister("Margaret", "Thatcher", 1979)},
                {"TB", new PrimeMinister("Tony", "Blair", 1997)}
            };

            //Does not handle exception
            primeMinisters["JC"] = new PrimeMinister("Jim", "Callaghan", 1976);
            
            Console.WriteLine(primeMinisters["JC"]);

            Console.WriteLine();
        }

        //Basic sample
        private static void addNewValue()
        {
            var primeMinisters = new Dictionary<string, PrimeMinister>
            {
                {"JC", new PrimeMinister("James", "Callaghan", 1976)},
                {"MT", new PrimeMinister("Margaret", "Thatcher", 1979)},
                {"TB", new PrimeMinister("Tony", "Blair", 1997)}
            };

            //Add by key
            primeMinisters["JM"] = new PrimeMinister("John", "Major", 1990);
            Console.WriteLine(primeMinisters["JM"]);

            //Add by method
            primeMinisters.Add("DC", new PrimeMinister("David", "Cameron", 2010));
            Console.WriteLine(primeMinisters["DC"]);

            Console.WriteLine();
        }

        //Basic sample
        private static void removeValue()
        {
            var primeMinisters = new Dictionary<string, PrimeMinister>
            {
                {"JC", new PrimeMinister("James", "Callaghan", 1976)},
                {"MT", new PrimeMinister("Margaret", "Thatcher", 1979)},
                {"TB", new PrimeMinister("Tony", "Blair", 1997)}
            };

            primeMinisters.Remove("MT");

            foreach (var item in primeMinisters)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }

        //Key comparison
        private static void keyComparison()
        {
            var primeMinisters = new Dictionary<string, PrimeMinister>(StringComparer.CurrentCultureIgnoreCase)
            {
                {"JC", new PrimeMinister("James", "Callaghan", 1976)},
                {"MT", new PrimeMinister("Margaret", "Thatcher", 1979)},
                {"TB", new PrimeMinister("Tony", "Blair", 1997)}
            };

            Console.WriteLine(primeMinisters["JC"]);
            Console.WriteLine(primeMinisters["jc"]);
            Console.WriteLine(primeMinisters["jC"]);

            Console.WriteLine();
        }

        private static void sampleReadOnlyDict() {

            var pms = new Dictionary<string, PrimeMinister>(StringComparer.CurrentCultureIgnoreCase)
            {
                {"JC", new PrimeMinister("James", "Callaghan", 1976)},
                {"MT", new PrimeMinister("Margaret", "Thatcher", 1979)},
                {"TB", new PrimeMinister("Tony", "Blair", 1997)}
            };

            var primeMinisters = new ReadOnlyDictionary<string, PrimeMinister>(pms);

            foreach (var item in primeMinisters)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            Console.WriteLine();
        }

        private static void sampleSortedDict()
        {
            var primeMinisters = new SortedDictionary<string, PrimeMinister>
            {
                {"MT", new PrimeMinister("Margaret", "Thatcher", 1979)},
                {"TB", new PrimeMinister("Tony", "Blair", 1997)},
                {"JC", new PrimeMinister("James", "Callaghan", 1976)}                
            };

            primeMinisters["JM"] = new PrimeMinister("John", "Major", 1990);

            foreach (var item in primeMinisters)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            Console.WriteLine();
        }

        private static void sampleSortedList()
        {
            var primeMinisters = new SortedList<string, PrimeMinister>
            {
                {"MT", new PrimeMinister("Margaret", "Thatcher", 1979)},
                {"TB", new PrimeMinister("Tony", "Blair", 1997)},
                {"JC", new PrimeMinister("James", "Callaghan", 1976)}
            };

            primeMinisters["JM"] = new PrimeMinister("John", "Major", 1990);

            foreach (var item in primeMinisters)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            Console.WriteLine();
        }

        //End of Class
    }
}
