using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_2A
{
    class Stack
    {
        public static void CreatingStack()
        {
            Stack<string> People = new Stack<string>();

            //Filling the stack. 
            Console.WriteLine("\nPushing items onto the stack." );
            foreach (string person in new string[5] { "Christopher", "Sandi", "Carlos", "Victor", "Tony" })
            {
                People.Push(person);
                Console.WriteLine($"{person} has been pushed on the stack");
            }
            //iterating through the stack 
            Console.WriteLine("\nThe stack contains.");
            foreach (string person in People)
            {
                Console.WriteLine(person);
            }
        }
    }
}
