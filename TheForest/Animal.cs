using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheForest
{
    internal class Animal
    {
        public int Weight { get; set; }
        public bool Nocturnal { get; set; }
        public Animal(int weight, bool nocturnal)
        {
            Weight = weight;
            Nocturnal = nocturnal;
        }

        public Animal()
        {

        }

        public virtual void Move(bool day)
        {
            Console.WriteLine("Djuret sover eller är vaket");
        }

        public void showAnimalStory(List<Animal> forest, bool day)
        {
            foreach (Animal animal in forest)
            {
                Console.WriteLine("Vikt: " + animal.Weight + " kg");
                Console.WriteLine("Nattdjur " + animal.Nocturnal);
                animal.Move(day);

                if (animal is Owl)
                {
                    //Säger att Animal är en owl, så du kommer åt wingspan som bara owls har
                    Console.WriteLine("Vingbredd: " + ((Owl)animal).WingSpan);
                }
                if (animal is Dolphin)
                {
                    Console.WriteLine("Fiskar per dag: " + ((Dolphin)animal).FishPerDay);
                }
                if (animal is Horse)
                {
                    Console.WriteLine("Hö per dag: " + ((Horse)animal).HayPerDay);
                }
                Console.WriteLine("");
            }
        }
    }

    internal class Owl : Animal
    {
        public int WingSpan { get; set; }
        public Owl(int weight, bool nocturnal, int wingspan) : base(weight, nocturnal)
        {
            WingSpan = wingspan;
        }

        public override void Move(bool day)
        {
            if (Nocturnal == true && day == false)
            {
                Console.WriteLine("Ugglan flyger bland träden och letar efter mat!");
            }
            else
            {
                Console.WriteLine("Ugglan sover i ett hål i trädet.");
            }
        }
    }

    internal class Dolphin : Animal
    {
        public int FishPerDay { get; set; }

        public Dolphin(int weight, bool nocturnal, int fishperday) : base(weight, nocturnal)
        {
            FishPerDay = fishperday;
            
        }
        public override void Move(bool day)
        {
            if (Nocturnal == false && day == true)
            {
                Console.WriteLine("Delfinen simmar elegant i sjön och fångar fisk");
            }
            else
            {
                Console.WriteLine("Delfinen flyter omkring sovandes");
            }
        }
    }

    internal class Horse : Animal
    {
        public int HayPerDay { get; set; }

        public Horse(int weight, bool nocturnal, int hayperday) : base(weight, nocturnal)
        {
            HayPerDay = hayperday;
        }
        public override void Move(bool day)
        {
            if (Nocturnal == false && day == true)
            {
                Console.WriteLine("Hästen går om kring och äter hö");
            }
            else
            {
                Console.WriteLine("Hästen sover under trädet.");
            }
        }
    }
}
