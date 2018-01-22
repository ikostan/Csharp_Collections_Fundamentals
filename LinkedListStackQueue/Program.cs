using System;

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

        }

        private static void SampleLinkedListNode()
        {
            Console.WriteLine("Linked List Node - required to store items in a linked list\n");

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
