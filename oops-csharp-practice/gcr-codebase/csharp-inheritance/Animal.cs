using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Oops.Inheritance
{
    internal class Animal
    {
        public string AnimalName;
        public double weight;

        public Animal(string AnimalName, double weight)
        {
            this.AnimalName = AnimalName;
            this.weight = weight;
        }

        // Virtual method
        public virtual void AnimalSounds()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }


    // Subclass: Dog
    class DogAnimal : Animal
    {
        public DogAnimal(string AnimalName, double weight) : base(AnimalName, weight) { }

        public override void AnimalSounds()
        {
            Console.WriteLine("Dog barks");
        }
    }


    // Subclass: Cat
    class Cat : Animal
    {
        public Cat(string AnimalName, double weight) : base(AnimalName, weight) { }

        public override void AnimalSounds()
        {
            Console.WriteLine("Cat meows");
        }
    }


    // Subclass: Bird
    class Bird : Animal
    {
        public Bird(string AnimalName, double weight) : base(AnimalName, weight) { }

        public override void AnimalSounds()
        {
            Console.WriteLine("Bird chirps");
        }
    }


    class AnimalKingdom
    {
        static void AnimalHeirarchy()
        {
            // Polymorphism
            Animal animal1 = new DogAnimal("Doggy", 3);
            Animal animal2 = new Cat("Meowy", 2);
            Animal animal3 = new Bird("Chirpy", 1);

            animal1.AnimalSounds();
            animal2.AnimalSounds();
            animal3.AnimalSounds();
        }
    }
}
