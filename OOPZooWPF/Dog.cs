using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPZooWPF
{
    class Dog : Animals, ISwimmable
    {




        public Dog(string name, string species, int age, string habitat) : base(name, species, age, habitat)
        {
        }

        public override void Feed()
        {
            Console.WriteLine($"{Name} the {Species} is happily eating its food, wagging its tail in excitement."); 
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the {Species} barks happily, its tail wagging with excitement.");
        }

        public override void Sleep()
        {
            Console.WriteLine($"{Name} the {Species} curls up in its cozy bed, closing its eyes to rest peacefully.");
        }

        public void Swim()
        {
            Console.WriteLine($"{Name} is swimming joyfully in the water, splashing around with its paws.");
        }
    }
}
