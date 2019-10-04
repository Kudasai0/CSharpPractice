using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Car
    {
        private int weight;
        private string color;
        private int maxSpeed;
        private int fuelConsumption;

        public Car()
        {
            weight = 0;
            maxSpeed = 0;
            fuelConsumption = 0;
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public string Color { get; set; }

        public int MaxSpeed
        {
            get { return maxSpeed; }
            set { maxSpeed = value; }
        }

        public int FuelConsumprion
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }
    }
}
