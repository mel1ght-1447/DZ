using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр1
{
    internal class Fish
    {
        public string Name { set; get; }
        public uint Age { set; get; }
        public double Length { set; get; }
        public double Weight { set; get; }
        public string Habitat { set; get; }
        public string Eats { set; get; }



        public Fish(string Name, uint Age, double Length, double Weight, string Habitat, string Eats)
        {
            this.Name = Name;
            this.Age = Age;
            this.Length = Length;
            this.Weight = Weight;
            this.Habitat = Habitat;
            this.Eats = Eats;
        }
        
    }
}
