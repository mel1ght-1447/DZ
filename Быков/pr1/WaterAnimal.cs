using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр1
{
    internal class WaterAnimal
    {
        public string Name { set; get; }
        public uint Age { set; get; }
        public double Length { set; get; }
        public double Weight { set; get; }


        public WaterAnimal(string Name, uint Age, double Length, double Weight)
        {
            this.Name = Name;
            this.Age = Age;
            this.Length = Length;
            this.Weight = Weight;
        }

    }
}

