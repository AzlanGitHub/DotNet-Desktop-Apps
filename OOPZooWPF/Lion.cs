using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPZooWPF
{
    class Lion: Animals
    {
        public string Gender { get; set; }
        public bool ISKingOfTheJungle { get; set; } = true;
        public bool IsPrideLeader { get; set; } = true;
        public double BodyLength { get; set; } // in meters
        public double DailyHuntingDistance { get; set; } // in kilometers

        public Lion(string name, string species, int age, string habitat) : base(name, species, age, habitat){}



        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the {Species} roars majestically, its powerful voice echoing through the savannah.");
        }

        public override void Sleep()
        {
            Console.WriteLine($"{Name} the {Species} lies down under the shade of a tree, closing its eyes to rest.");

        }



        public override string ToString()
        {
            return $"{Name} the {Species}, Age: {Age}";
        }

        public override void Feed()
        {
           Console.WriteLine($"{Name} the {Species} is hunting for prey, using its keen senses to stalk through the tall grass of the savannah.");
        }
    }
    
    
}
