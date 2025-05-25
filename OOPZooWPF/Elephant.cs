using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPZooWPF
{
    class Elephant: Animals
    {
        public double TrunkLength { get; set; } // in meters
        public double DailyWaterIntake { get; set; } // in liters
        public bool IsTusker { get; set; } // Indicates if the elephant has tusks
        public Elephant(string name, string species, int age, string habitat) : base(name, species, age, habitat){ }
       
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the {Species} trumpets loudly, its deep voice resonating through the savannah.");
        }
        public override void Sleep()
        {
            Console.WriteLine($"{Name} the {Species} lies down under a tree, closing its eyes to rest peacefully.");
        }

        public override void Feed()
        {
           Console.WriteLine($"{Name} the {Species} is using its trunk to pick leaves and branches, enjoying a hearty meal of vegetation.");
        }
    }
    {
    }
}
