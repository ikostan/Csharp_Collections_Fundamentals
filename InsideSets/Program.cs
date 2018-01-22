using System;
using System.Linq;
using System.Collections.Generic;

namespace InsideSets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inside Sets: used mainly for comparisons between data sets\n");

            //HashSetSample();
            SortedSetSample();

            Console.WriteLine("Please enter any key to exit...");
            Console.ReadKey();
        }

        private static void HashSetSample()
        {
            Console.WriteLine("HashSet: " +
                "collection of elements with no order, " +
                "contains unique items only, " +
                "using Hash Table, " +
                "no keys but values only\n");

            var cities = new List<string> {
                "New York",
                "Washington",
                "Moskow",
                "Budapesht",
                "New York",
                "Washington".ToLower(),
                "Moskow",
                "Budapesht".ToUpper()
            };

            Console.WriteLine($"List size: {cities.Count}");
            Console.WriteLine();

            HashSet<string> citiesSet = new HashSet<string>();

            foreach(string c in cities)
            {
                citiesSet.Add(c);
            }

            Console.WriteLine($"Setsize: {citiesSet.Count}");
            Console.WriteLine();

            foreach (string c in citiesSet)
            {
                Console.WriteLine(c);
            }

            //Use comparer before adding to the HashSet
            HashSet<string> citiesSetUniqueq = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase);

            foreach (string c in cities)
            {
                citiesSetUniqueq.Add(c);
            }

            Console.WriteLine($"Setsize: {citiesSetUniqueq.Count}");
            Console.WriteLine();

            foreach (string c in citiesSetUniqueq)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine();

            //Find intersections
            Console.WriteLine("\nFind intersections:");
            var interCities = citiesSet.Intersect(citiesSetUniqueq);

            foreach (string c in interCities)
            {
                Console.WriteLine(c);
            }

            //Union
            Console.WriteLine("\nUnion:");
            var unionCities = citiesSet.Union(citiesSetUniqueq);

            foreach (string c in unionCities)
            {
                Console.WriteLine(c);
            }

            //Difference
            Console.WriteLine("\nDifference:");
            var diffCities = citiesSet.Except(citiesSetUniqueq);

            foreach (string c in diffCities)
            {
                Console.WriteLine(c);
            }

            //Symetric Difference
            Console.WriteLine("\nSymetric Difference:");
            citiesSet.SymmetricExceptWith(citiesSetUniqueq);

            foreach (string c in citiesSet)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine();
        }

        private static void SortedSetSample()
        {
            Console.WriteLine("SortedSet: \n");

            var cities = new List<string> {
                "New York",
                "Washington",
                "Moskow",
                "Budapesht",
                "New York",
                "Washington".ToLower(),
                "Moskow",
                "Budapesht".ToUpper()
            };

            Console.WriteLine($"List size: {cities.Count}");
            Console.WriteLine();

            SortedSet<string> citiesSet = new SortedSet<string>();

            foreach (string c in cities)
            {
                citiesSet.Add(c);
            }

            Console.WriteLine($"Setsize: {citiesSet.Count}");
            Console.WriteLine();

            foreach (string c in citiesSet)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine();
        }

        //End of Class
    }
}
