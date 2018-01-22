using System;
using System.Collections.Generic;

namespace LinkedListStackQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked Lists, Stacks and Queues:\n");

            //SampleLinkedList();
            //SampleStack();
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

            //Replace an element:
            presidents.RemoveFirst();
            presidents.AddFirst("John F Kennedy");

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
            Stack<string> stack = new Stack<string>();

            stack.Push("John F Kennedy");
            stack.Push("Lyndon B Johnson");
            stack.Push("Gerard Ford");
            stack.Push("Richard Nixon");
            stack.Push("Jimmy Carter");

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }

            Console.WriteLine();
        }

        private static void SampleQueue()
        {
            Console.WriteLine("Queue - FIFO\n");
            Queue<string> stack = new Queue<string>();

            stack.Enqueue("John F Kennedy");
            stack.Enqueue("Lyndon B Johnson");
            stack.Enqueue("Gerard Ford");
            stack.Enqueue("Richard Nixon");
            stack.Enqueue("Jimmy Carter");

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Dequeue());
            }

            Console.WriteLine();
        }

        //End of class
    }
}
