using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.Scenario_bases.BirdSanctuarySystem
{
    internal class Sparrow: BirdClass, IsFlyable
    {
        public Sparrow(string idOfBird, string BirdName,
                     string speciesOfBird, string birdColour,
                     int birdAge) : base(idOfBird, BirdName, speciesOfBird, birdColour, birdAge) { }

        public void Flying()
        {
            Console.WriteLine("Sparrow flies");
        }

    }
}
