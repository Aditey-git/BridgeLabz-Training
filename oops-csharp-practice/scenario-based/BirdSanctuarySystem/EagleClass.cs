using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.Scenario_bases.BirdSanctuarySystem
{
    internal class EagleClass : BirdClass, IsFlyable
    {
        public EagleClass(string idOfBird, string birdName,
                     string speciesOfBird, string birdColour,
                     int birdAge) : base(idOfBird, birdName, speciesOfBird, birdColour, birdAge) { }

        public void Flying()
        {
            Console.WriteLine("Eagle flies");
        }

    }
}
