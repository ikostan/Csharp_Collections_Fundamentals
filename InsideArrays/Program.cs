using System;

namespace InsideArrays
{
    class Program
    {
        private static string[] daysOfTheWeek;

        static void Main(string[] args)
        {
            Console.WriteLine("Inside Arrays: index based list (ordered, fixed size)\n");

            //Basic definition
            daysOfTheWeek = new string[] {
                "Monday",
                "Tuesday",
                "Wensday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            BasicSample();
            EnumerationSample();
            ReplaceElement();

            Console.WriteLine("Please enter any key to exit...");
            Console.ReadKey();
        }

        private static void ReplaceElement()
        {
            daysOfTheWeek[0] = "Start";
            //Display element by index
            Console.WriteLine(daysOfTheWeek[0]);
        }

        private static void BasicSample()
        {
            try
            {
                Console.WriteLine("\nType the index of the day to look up:");
                int day = int.Parse(Console.ReadLine());

                //Display element by index
                Console.WriteLine(daysOfTheWeek[day]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void EnumerationSample()
        {
            //Enumeration:
            Console.WriteLine("Days of the week:\n");
            foreach (var item in daysOfTheWeek)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }

        //End of Class
    }
}
