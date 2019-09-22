using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_2A
{
    class LinkedList
    {
        public static void CreatingLinkedList()
        {
            LinkedList<int> numbers = new LinkedList<int>();

            //Filling the list using the AddFirst method. 
            foreach (int number in new int[] { 10, 8, 6, 4, 2 })
            {
                numbers.AddFirst(number);
            }
            //Iterate using a foreach statement.
            Console.WriteLine("\nLinkedList Example");
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
            //Iterate backwards with a for loop for fun.
            Console.WriteLine("Iterating list in reverse order");
            for (LinkedListNode<int> node = numbers.Last; node != null; node = node.Previous)
            {
                int number = node.Value;
                Console.WriteLine(number);
            }
        }
    }
}
