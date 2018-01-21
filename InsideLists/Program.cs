using System;
using System.Collections.Generic;

namespace InsideLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inside Lists: index based collection\n");

            //Basic declaration + methods
            List<string> names = new List<string>() { "John", "Donald", "Bob", "Sean", "Frank" };
            Console.WriteLine($"Size: {names.Count}");
            names.Add("Bruce");
            Console.WriteLine($"Size: {names.Count}");
            Console.WriteLine($"Last added name: {names[names.Count - 1]}");


            Console.WriteLine("Please enter any key to exit...");
            Console.ReadKey();
        }
    }
}
