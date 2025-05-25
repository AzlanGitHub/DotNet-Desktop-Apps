using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPZooWPF
{
    public abstract class Animals
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public string color { get; set; }
        public string Habitat { get; set; }
        public bool IsAdopted { get; set; } = false;
        public bool IsAvailableForAdoption { get; set; } = true;
        public bool IsHealthy { get; set; } = true;

        public string Description
        {
            get
            {
                return $"{Name} is a {Species} aged {Age} years, living in {Habitat}.";
            }
        }
        
        public Animals(string name, string species, int age, string habitat)
        {
            Name = name;
            Species = species;
            Age = age;
            Habitat = habitat;
        }

        public abstract void MakeSound();
        public abstract void Feed();
        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing.");
        }

        public abstract void Sleep();
    
        public override string ToString()
        {
            return $"{Name} ({Species}), Age: {Age}, Habitat: {Habitat}";
        }
    }
}
