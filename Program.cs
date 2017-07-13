using System;
using System.Collections.Generic;

namespace hashsets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> showRoom = new HashSet<string>();
            showRoom.Add("Mazda Miata");
            showRoom.Add("Ford Mustang");
            showRoom.Add("Hyundai Elantra");
            showRoom.Add("Chevy Cruze");
            Console.WriteLine(showRoom.Count);
            showRoom.Add("Chevy Cruze");
            Console.WriteLine(showRoom.Count);
            HashSet<string> usedLot = new HashSet<string>();
            usedLot.Add("Lotus Elise");
            usedLot.Add("Toyota Camry");
            showRoom.UnionWith(usedLot);
            Console.WriteLine(showRoom.Count);
            showRoom.Remove("Lotus Elise");
            Console.WriteLine(showRoom.Count);
            HashSet<string> junkyard = new HashSet<string>();
            junkyard.Add("Toyota Camry");
            junkyard.Add("Honda Fit");
            junkyard.Add("Chevy Cruze");
            junkyard.Add("Kia Soul");
            // junkyard.IntersectWith(showRoom);
            Console.WriteLine(junkyard.Count);
            showRoom.UnionWith(junkyard);
            showRoom.Remove("Kia Soul");
            Console.WriteLine(showRoom.Count);
        }
    }
}