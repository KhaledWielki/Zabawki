using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Submarine : IDive, IAccelerate, IToy

    {
        double acceleration;
        double dive;
        double price;
        string name;
        public void SetAcceleration(double newAcceleration)
        {
            this.acceleration = newAcceleration;
        }

        public double GetAcceleration()
        {
            return this.acceleration;
        }

        public void SetDive(double newDive)
        {
            this.dive = newDive;
        }

        public double GetDive()
        {
            return this.dive;
        }

        public void SetName(string newName)
        {
            this.name = newName;
        }

        public void SetPrice(double newPrice)
        {
            this.price = newPrice;
        }

        public string GetName()
        {
            return this.name;
        }

        public double GetPrice()
        {
            return this.price;
        }
    }
}
