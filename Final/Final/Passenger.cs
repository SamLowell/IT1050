using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Passenger
    {
        public string Name { get; set; }
        public double Weight { get; set; }

        public Passenger (string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public string GetName()
        {
            return Name;
        }

        public double GetWeight()
        {
            return Weight;
        }



    }
}
