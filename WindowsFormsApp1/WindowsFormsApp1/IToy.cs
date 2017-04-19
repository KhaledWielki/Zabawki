using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    interface IToy
    {
        void SetName(string newName);
        void SetPrice(double newPrice);
        string GetName();
        double GetPrice();
    }
}
