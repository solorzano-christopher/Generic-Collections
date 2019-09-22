using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_2A
{
    class List
    {
        public static void CreatingList()
        {

            List<int> numbers = new List<int>();

            //Filling the list using the Add method...
            foreach (int number in new int[12] { 10, 9, 8, 7, 7, 6, 5, 10, 4, 3, 2, 1 })
            {
                numbers.Add(number);
            }
            Console.WriteLine("Creating a list example");
            //Print the List using a for loop. A foreach may also work.
            for (int i = 0; i < numbers.Count; i++)
            {
                int number = numbers[i]; // Note the use of array syntax
                Console.WriteLine(number);
            }
        }
    }
}
