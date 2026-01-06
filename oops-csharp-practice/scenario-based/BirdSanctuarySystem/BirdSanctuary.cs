using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Summary =>  
This program represents a Bird Sanctuary System using object-oriented principles in C#.
An array of BirdClass objects stores different bird types like Eagle, Sparrow, Duck, Penguin, and Seagull.
Each bird object is initialized with unique attributes such as ID, name, species, color, and age.
The program iterates through the array and displays each bird’s basic information using polymorphism.
It uses the is keyword to check whether a bird can fly or swim.
If supported, the corresponding Flying() or Swimming() behavior is executed.
This demonstrates inheritance, interfaces, and runtime polymorphism effectively.
 */

namespace BridgeLabzTraining2.Oops.Scenario_bases.BirdSanctuarySystem
{

    //Main class for the bird Sanctuary operations
    internal class BirdSanctuary
    {
        static void Main(string[] args)
        {
            BirdClass[] birdsArr = new BirdClass[5];


            // Initializing different bird objects
            birdsArr[0] = new EagleClass("B1", "Eagle One", "Eagle", "Brown", 5);
            birdsArr[1] = new Sparrow("B2", "Sparrow One", "Sparrow", "Grey", 2);
            birdsArr[2] = new DuckClass("B3", "Duck One", "Duck", "White", 3);
            birdsArr[3] = new PenguinClass("B4", "Penguin One", "Penguin", "Black & White", 4);
            birdsArr[4] = new SeagullClass("B5", "Seagull One", "Seagull", "White", 3);

            Console.WriteLine("===== BIRD SANCTUARY REPORT =====\n");

            // Iterating through each bird in the array
            foreach (BirdClass bird in birdsArr)
            {
                Console.WriteLine("--------------------------------");
                bird.InfoDisplay();

                if (bird is IsFlyable flyableBird)
                {
                    flyableBird.Flying();
                }

                if (bird is IsSwimable swimmableBird)
                {
                    swimmableBird.Swimming();
                }

                Console.WriteLine("--------------------------------");
            }
        }

    }
}
