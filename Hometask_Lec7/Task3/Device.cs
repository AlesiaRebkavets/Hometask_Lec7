using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_Lec7.Task3
{
    public abstract class Device 
    { 

        public string? modelName;
        public decimal price;
        public Device(string? modelName, decimal price)        // set initial object "model name" and "price" values data
        {
            this.modelName = modelName;
            this.price = price;
        }

        public abstract string Description { get; }             // abstract getter

        public abstract void TurnOn();                          // abstract method to turn on the device

        public void TunrnOff()                                  // non-abstract method to turn off the device
        {
            Console.WriteLine("Press Turn Off button");
        }
    }
}
