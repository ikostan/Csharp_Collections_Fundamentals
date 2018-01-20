using System;

namespace InsideArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inside Arrays: index based list (ordered, fixed size)\n");

            BasicSample();

            Console.WriteLine("Please enter any key to exit...");
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

            try
            {
                Console.WriteLine("Type the index of the day to look up:");
                int day = int.Parse(Console.ReadLine());

                //Display element by index
                Console.WriteLine(daysOfTheWeek[day]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
