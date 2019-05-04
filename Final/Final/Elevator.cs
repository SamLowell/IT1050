using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Elevator
    {
        public double MaxWeight { get; set; }
        private Passenger[] Occupants;

        public Elevator(int maxOccupants, double maxWeight)
        {
            MaxWeight = maxWeight;
            Occupants = new Passenger[maxOccupants];
        }

        public void AddOccupant(Passenger passenger, int index)
        {
            Occupants[index] = passenger;
        }

        public double GetCurrentWeight()
        {
            double CurrentWeight = 0;

            foreach(Passenger passenger in Occupants)
            {
                CurrentWeight += passenger.GetWeight();
            } 
                
            return CurrentWeight;
        }

        public bool IsOverMaxCapacity()
        {
            return this.GetCurrentWeight() > this.MaxWeight;

        }

    }
}
