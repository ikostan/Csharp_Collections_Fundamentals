using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace InsideLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inside Lists: index based collection\n");

            //BasicOperations();
            UsingObservableCollection();

            Console.WriteLine("Please enter any key to exit...");
            Console.ReadKey();
        }

        private static void UsingObservableCollection() {

            ObservableCollection<string> oList = new ObservableCollection<string>
            {
                "One",
                "Two",
                "Tree",
            };

            oList.CollectionChanged += ElementChanged;

            oList.Add("Four");
            oList.Remove("One");

        }

        private static void ElementChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Collection changed...");
        }

        private static void BasicOperations()
        {
            //Basic declaration + methods
            List<string> names = new List<string>(5) { "John", "Donald", "Bob", "Sean", "Frank" };

            Console.WriteLine($"Size: {names.Count}");
            Console.WriteLine($"Capacity: {names.Capacity}");
            names.Add("Bruce");

            Console.WriteLine($"Size: {names.Count}");
            Console.WriteLine($"Capacity: {names.Capacity}");
            Console.WriteLine($"Last added name: {names[names.Count - 1]}");

            names.Remove("John");
            Console.WriteLine($"First name in the list: {names[0]}");
            Console.WriteLine($"Size: {names.Count}");
            Console.WriteLine($"Capacity: {names.Capacity}");

            names.RemoveAt(names.Count - 1);
            Console.WriteLine($"Last name in the list: {names[names.Count - 1]}");
            Console.WriteLine($"Size: {names.Count}");
            Console.WriteLine($"Capacity: {names.Capacity}");

            names.Clear();
            Console.WriteLine($"Size: {names.Count}");
            Console.WriteLine($"Capacity: {names.Capacity}");
        }

        //End of Class
    }
}
