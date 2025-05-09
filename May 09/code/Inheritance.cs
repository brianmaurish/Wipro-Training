using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
     class Animal
    {
        public string Name;
        public string Species;

        public void DisplayAnimal()
        {
            Console.WriteLine("Animal Name: " + Name);
            Console.WriteLine("Species: " + Species);
        }
    }

    class Dog:Animal
    {
        public string Breed;

        public void DisplayDog()
        {
            Console.WriteLine("Breed: " + Breed);
        }
    }
}


namespace ConsoleApp7
{
    class Program
    {
        static void Main()
        {
            Dog myDog = new Dog();
            myDog.Name = "Buddy";
            myDog.Species = "Canine";
            myDog.Breed = "Labrador";

            myDog.DisplayAnimal();

            myDog.DisplayDog();
            

        }
    }
}


