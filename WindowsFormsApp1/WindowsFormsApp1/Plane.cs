using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Plane : IRise, IAccelerate, IToy
    {
        double acceleration;
        double rise;
        string name;
        double price;
        public double GetAcceleration()
        {
            return this.acceleration;
        }

        public string GetName()
        {
            return this.name;
        }

        public double GetPrice()
        {
            return this.price;
        }

        public double GetRise()
        {
            return this.rise;
        }

        public void SetAcceleration(double newAcceleration)
        {
            this.acceleration = newAcceleration;
        }

        public void SetName(string newName)
        {
            this.name = newName;
        }

        public void SetPrice(double newPrice)
        {
            this.price = newPrice;
        }

        public void SetRise(double newRise)
        {
            this.rise = newRise;
        }
    }
}
