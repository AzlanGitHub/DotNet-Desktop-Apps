using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPZooWPF
{
    public class Eagle : Animals, IFlyable
    {
        public string WingSpan { get; set; } 
        public string BeakType { get; set; } 
        public string TalonType { get; set; }
        public int FlightSpeed { get; set; } 
        public int EggCount { get; set; } 
        public bool IsMigratory { get; set; }
        public bool IsFlying { get; set; } 


        public Eagle(string name, string species, int age, string habitat) : base(name, species, age, habitat){}


   

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the {Species} screeches loudly, its sharp eyes scanning the surroundings.");
        }

        public override void Sleep()
        {
            Console.WriteLine($"{Name} the {Species} perches high on a tree branch, closing its eyes to rest.");

        }

        public void Fly()
        {
            Console.WriteLine($"{Name} is soaring through the sky with a wingspan of {WingSpan} and a flight speed of {FlightSpeed} km/h.");
        }

        public override void Feed()
        {
            Console.WriteLine($"{Name} is hunting for prey, using its sharp talons and keen eyesight to spot small animals from high above.");
        }
    }
}
