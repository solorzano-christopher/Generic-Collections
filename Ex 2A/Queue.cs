using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_2A
{
    class Queue
    {
        public static void CreatingQueue()
        {
            Queue<string> members = new Queue<string>();

            //filling the Queue
            Console.WriteLine("\nCreating a Queue example.");
            foreach (string member in new string[5] {"Christohper","Sandi","Tony", "Carlos","Jon"})
            {
                members.Enqueue(member);
                Console.WriteLine($"{member} has joined the queue! Get comfortable.");
            }
            //Iterating through the queue.
            Console.WriteLine("\nThe queue contains the following members");
            foreach(string member in members)
            {
                Console.WriteLine(member);
            }
            //emptying the queue for practice.
            Console.WriteLine("\nLeaving the queue");
            while (members.Count > 0)
            {
                string member = members.Dequeue();
                Console.WriteLine($"{member} has left the queue!");
            }
        }
    }
}
