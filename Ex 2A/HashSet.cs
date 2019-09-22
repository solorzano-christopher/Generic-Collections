using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_2A
{
    class HashSet
    {
        public static void CreatingHashSet()
        {
            HashSet<string> MotorcycleRiders = new HashSet<string>(new string[5] 
            { "Christopher", "Andres", "Ashton", "Dylan", "Alex" });
            HashSet<string> CarEnthusiast = new HashSet<string>(new string[5]
            {"Christopher","Jon","Andres","Mauricio","Eli"});

            //Demostrating how to add more.
            MotorcycleRiders.Add("Dan");
            CarEnthusiast.Add("Tony");

            Console.WriteLine("\nMotorcycle Riders:");
            foreach(string name in MotorcycleRiders)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("\nCar Enthusiast");
            foreach(string name in CarEnthusiast)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("\nMotorcycle Riders who are also Car Enthusiasts");
            MotorcycleRiders.IntersectWith(CarEnthusiast);
            foreach(string name in MotorcycleRiders)
            {
                Console.WriteLine(name);
            }
        }
    }
}
