using System;

namespace InsideArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inside Arrays: index based list (ordered, fixed size)\n");

            BasicSample();

            Console.ReadKey();
        }

        private static void BasicSample()
        {
            //Basic definition
            string[] daysOfTheWeek = new string[] {
                "Monday",
                "Tuesday",
                "Wensday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            //Display forst element (index zero)
            Console.WriteLine(daysOfTheWeek[0]);
        }
    }
}
