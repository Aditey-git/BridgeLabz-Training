using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.Oops.Scenario_bases.BirdSanctuarySystem
{
    internal class SeagullClass: BirdClass, IsSwimable, IsFlyable
    {
        public SeagullClass(string idOfBird, string nameOfBird,
                     string speciesOfBird, string colorOfBird,
                     int birdAge) : base(idOfBird, nameOfBird, speciesOfBird, colorOfBird, birdAge) { }

        public void Flying()
        {
            Console.WriteLine("Seagull flies");
        }

        public void Swimming()
        {
            Console.WriteLine("Seagull swims");
        }

    }
}
