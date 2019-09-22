using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_2A
{
    class Dictionary
    {
        public static void CreatingDictionary()
        {
            Dictionary<string, int> ages = new Dictionary<string, int>();
            //filling the Dictionary
            ages.Add("Christopher", 22); //using the Add method 
            ages.Add("Sandi", 20);
            ages["Tony"] = 25;//using array nontation
            ages["Jon"] = 24;
            ages["Ares"] = 1;

            //itering using a foreach statment. The iterator generates a KeyValuePair item
            Console.WriteLine("\nThe Dictionary Contains");
            foreach (KeyValuePair<string, int> element in ages)
            {
                string name = element.Key;
                int age = element.Value;
                Console.WriteLine($"Name: {name}, Age:{age}");
            }
        }
    }
}
