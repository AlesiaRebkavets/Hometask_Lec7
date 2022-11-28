using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_Lec7.Task3
{
    public abstract class Device 
    { 

        public string modelName;
        public decimal price;
        public Device(string modelName, decimal price)         // set initial object "model name" and "price" values data
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

    public abstract class PrintingDevice: Device
        // у классов Printer и Polaroid есть переменные "private int paperWidth" и "private int paperHeight" 
        // чтобы не было дублирования кода, их нужно вынести в отдельный абстрактный класс
        // класс Device для этого не подходит, так как в классе MobilePhone этих переменных быть не должно
        // интерфейсы тоже не подходят, так как это не константы, а переменные величины, значения которых должен задать пользователь используя конструктор
        // поэтому было решено создать еще один абстрактный класс, наследника класса Device
    {
        private int paperWidth;
        private int paperHeight;
        public PrintingDevice (string modelName, decimal price, int paperWidth, int paperHeight): base(modelName, price)        // set initial object "model name" and "price" values data
        {
            this.paperWidth = paperWidth;
            this.paperHeight = paperHeight;
        }
    }
    interface IPrint
    {
        public void Print()
        {
            Console.WriteLine("Printing...\n");                // outputs printing action
        }
    }

    interface ITakePhoto
    {
        public void TakePhoto();        // the method is overriden in classes 'MobilePhone' and 'Polaroid'
    }
}
