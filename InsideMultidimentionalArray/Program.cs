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

            //sampleMultiDimentionalArray();
            sampleJaggedArray();

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
            Console.WriteLine($"Rank (# of dimentions): {twoDarray.Rank}\n");

            //Using length
            for (int row = 0; row < twoDarray.GetLength(0); row++)
            {
                for (int col = 0; col < twoDarray.GetLength(1); col++)
                {
                    Console.Write(twoDarray[row, col] + ", ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //Using bounds
            for (int row = twoDarray.GetLowerBound(0); row <= twoDarray.GetUpperBound(0); row++)
            {
                for (int col = twoDarray.GetLowerBound(1); col <= twoDarray.GetUpperBound(1); col++)
                {
                    Console.Write(twoDarray[row, col] + ", ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        private static void sampleJaggedArray()
        {
            int[][] jArray = new int[3][]
            {
                new int[]{ 1, 2, 3, 4, 5 },
                new int[]{ 6, 7, 8, 9, 10, 11 } ,
                new int[]{ 12, 13, 14, 15, 15, 16, 17 }
            };

            Console.WriteLine($"Total length: {jArray.Length}\n");
            Console.WriteLine($"Rank (# of dimentions): {jArray.Rank}\n");

            //Using length
            for (int row = 0; row < jArray.Length; row++)
            {
                Console.WriteLine($"\nTotal length: {jArray[row].Length}\n");
                Console.WriteLine($"Rank (# of dimentions): {jArray[row].Rank}\n");
                for (int col = 0; col < jArray[row].Length; col++)
                {
                    Console.Write(jArray[row][col] + ", ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        //End of Class
    }
}
