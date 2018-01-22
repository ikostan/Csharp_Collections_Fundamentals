using System;
using System.Collections.Generic;

namespace LinkedListStackQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked Lists, Stacks and Queues:\n");

            SampleLinkedList();
            SampleLinkedListNode();
            SampleStack();
            SampleQueue();

            Console.WriteLine("Please press any key to exit...\n");
            Console.ReadKey();
        }

        private static void SampleLinkedList()
        {
            Console.WriteLine("Linked Lists - allows fast adding/removing elements\n");

            //Create a new collection
            var presidents = new LinkedList<string>();
            presidents.AddLast("JFK");
            presidents.AddLast("Lyndon B Johnson");
            presidents.AddLast("Richard Nixon");
            presidents.AddLast("Jimmy Carter");

            //Enumerate
            foreach (string p in presidents)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine();

            //Add a new node
            presidents.AddAfter(presidents.Find("Richard Nixon"), "Gerard Ford");

            //Enumerate
            foreach (string p in presidents)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine();
        }

        private static void SampleStack()
        {
            Console.WriteLine("Stack - LIFO\n");

        }

        private static void SampleQueue()
        {
            Console.WriteLine("Queue - FIFO\n");

        }

        //End of class
    }
}
