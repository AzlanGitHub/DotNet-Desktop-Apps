using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPZooWPF
{
    class Dolphin : Animals, ISwimmable
    {

        public string FinType { get; set; } 

        public Dolphin(string name, string species, int age, string habitat) : base(name, species, age, habitat)
        {
        }



        public override void MakeSound()
        {
            throw new NotImplementedException();
        }

        public override void Sleep()
        {
            Console.WriteLine($"{Name} the {Species} is resting in the shallow waters, closing its eyes to relax.");
        }

        public void Swim()
        {
            Console.WriteLine($"{Name} is swimming gracefully in the water.");
        }

        public override void Feed()
        {
            Console.WriteLine($"{Name} is hunting for fish, using its echolocation to find prey in the water.");
        }
    }
}
