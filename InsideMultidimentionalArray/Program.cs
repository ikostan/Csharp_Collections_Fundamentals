using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsideMultidimentionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inside Multidimentional Arrays:\n");

            sampleMultiDimentionalArray();


            Console.WriteLine("Please press any key to exit...\n");
            Console.ReadKey();
        }

        private static void sampleMultiDimentionalArray()
        {
            int[,] twoDarray = new int[3, 5] 
            {
                { 1, 2, 3, 4, 5 },
                { 6, 7, 8, 9, 10 } ,
                { 11, 12, 13, 14, 15 }
            };

            Console.WriteLine($"Total length: {twoDarray.Length}\n");

            for (int row = 0; row < twoDarray.GetLength(0); row++)
            {
                for (int col = 0; col < twoDarray.GetLength(1); col++)
                {
                    Console.Write(twoDarray[row, col] + ", ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        //End of Class
    }
}
