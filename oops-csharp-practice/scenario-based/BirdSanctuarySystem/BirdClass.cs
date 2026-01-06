using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.Scenario_bases.BirdSanctuarySystem
{


    //Class for must have properties of Bus
    abstract class BirdClass
    {

        //Attributes
        private string idOfBird;
        private string birdName;
        private string speciesOfBird;
        private string birdColour;
        private int ageOfBird;


        //Constructor
        public BirdClass(string idOfBird, string birdName, string speciesOfBird, string birdColour, int ageOfBird)
        {
            this.idOfBird = idOfBird;
            this.birdName = birdName;
            this.speciesOfBird = speciesOfBird;
            this.birdColour = birdColour;
            this.ageOfBird = ageOfBird;
        }

        public virtual void InfoDisplay()
        {
            Console.WriteLine("------Bird Info------");
            Console.WriteLine("---------------------");
            Console.WriteLine($"Bird ID --> {idOfBird}");
            Console.WriteLine($"Name --> {birdName}");
            Console.WriteLine($"Species --> {speciesOfBird}");
            Console.WriteLine($"Color --> {birdColour}");
            Console.WriteLine($"Age --> {ageOfBird}");
        }
    }
}
