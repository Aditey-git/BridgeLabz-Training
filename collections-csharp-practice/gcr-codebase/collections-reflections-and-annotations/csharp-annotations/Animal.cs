using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTrainingCollectionsAAndFurther3.Annotations.cs
{
    internal class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }


    class AnimalKingdom
    {
        public static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.MakeSound();   
        }
    }
}
