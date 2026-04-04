using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.Scenario_bases.BirdSanctuarySystem
{
    internal class PenguinClass : BirdClass, IsSwimable
    {
        public PenguinClass(string idOfBird, string birdName,
                     string birdSpecies, string birdColour,
                     int birdAge) : base(idOfBird, birdName, birdSpecies, birdColour, birdAge) { }

        public void Swimming()
        {
            Console.WriteLine("Penguin swims");
        }

    }
}
