using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheForest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool day = true;
            List<Animal> forest = new List<Animal>();

            forest.Add(new Owl(2, true, 55));
            forest.Add(new Horse(400, false, 10));
            forest.Add(new Dolphin(500, false, 30));
            forest.Add(new Dolphin(480, false, 25));


            Animal animal = new Animal();
            while(true)
            {
                day = Menu(day);
                animal.showAnimalStory(forest, day);
            }

        }
        public static bool Menu(bool day)
        {
            Console.WriteLine("Nu är det " + (day ? "dag" : "natt"));

            string key = Console.ReadKey(true).Key.ToString();
            switch (key)
            {
                case "D":
                    day = true;
                    break;
                case "N":
                    day = false;
                    break;
            }
            Console.Clear();
            return day;
        }

    }
}
