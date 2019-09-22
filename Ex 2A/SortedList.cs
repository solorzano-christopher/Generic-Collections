using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_2A
{
    class SortedList
    {
      public static void CreatingSortedList()
        {
            SortedList<string, int> ages = new SortedList<string, int>();
            //filling the SortedList
            ages.Add("Christopher", 22); //using the Add method 
            ages.Add("Sandi", 20);
            ages["Tony"] = 25;//using array nontation
            ages["Jon"] = 24;
            ages["Ares"] = 1;

            Console.WriteLine("\nThe SortedList conatins");
            foreach (KeyValuePair<string,int>element in ages)
            {
                string name = element.Key;
                int age = element.Value;
                Console.WriteLine($"Name:{name} , Age:{age} ");
            }
        }
    }
}
