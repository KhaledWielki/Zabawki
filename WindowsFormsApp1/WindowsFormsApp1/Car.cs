using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Car : IAccelerate, IToy
    {
        double acceleration;
        double price;
        string name;

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
    }
}
