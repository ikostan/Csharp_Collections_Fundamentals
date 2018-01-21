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
            daysOfTheWeek = new string[] 
            {
                "Monday",
                "Tuesday",
                "Wensday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
                "Sunday"
            };

            //BasicSample();
            //EnumerationSample();
            //ReplaceElement();
            //ReverseSample();
            //SortSample();

            //Console.WriteLine(GetFirstIndex("x", daysOfTheWeek));
            //Console.WriteLine(GetFirstIndex("Sunday", daysOfTheWeek));

            //Console.WriteLine(GetLastIndex("x", daysOfTheWeek));
            //Console.WriteLine(GetLastIndex("Sunday", daysOfTheWeek));

            Console.WriteLine("Please enter any key to exit...");
            Console.ReadKey();
        }

        //
        private static int GetLastIndex(string word, string[] arr)
        {
            return Array.LastIndexOf(arr, word);
        }

        //
        private static int GetFirstIndex(string word, string[] arr)
        {
            return Array.IndexOf(arr, word);
        }

        //
        private static void ReplaceElement()
        {
            daysOfTheWeek[0] = "Start";
            //Display element by index
            Console.WriteLine(daysOfTheWeek[0]);
        }

        //
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

        //
        private static void EnumerationSample()
        {
            //Enumeration:
            Console.WriteLine("Days of the week:\n");
            foreach (var item in daysOfTheWeek)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();

            for(int i = 0; i < daysOfTheWeek.Length; i++)
            {
                Console.Write(daysOfTheWeek[i] + ", ");
            }
            Console.WriteLine();
        }

        //
        private static void ReverseSample()
        {
            Array.Reverse(daysOfTheWeek);

            foreach (var item in daysOfTheWeek)
            {
                Console.Out.Write(item + ", ");
            }
            Console.Out.WriteLine();
        }

        //
        private static void SortSample()
        {
            Array.Reverse(daysOfTheWeek);

            foreach (var item in daysOfTheWeek)
            {
                Console.Out.Write(item + ", ");
            }
            Console.Out.WriteLine();
        }

        //End of Class
    }
}
