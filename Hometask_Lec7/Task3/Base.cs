using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_Lec7.Task3
{
    internal class Base
    {
        static void Main()
        {
            MobilePhone phone = new MobilePhone("nokia", 200, 10);              // initialization of objects
            Polaroid polaroid1 = new Polaroid("xiaomi", 500, 5, 7, 16);
            IPrint polaroid2 = new Polaroid("sony", 800, 5, 7, 18);
            Printer printer1 = new Printer("LG", 300, 15, 25);
            IPrint printer2 = new Printer("samsung", 400, 15, 25);

            Console.WriteLine(phone.Description);                               // output the description of the objects; overriden getter was used     
            Console.WriteLine(polaroid1.Description);
            Console.WriteLine(printer1.Description);

            phone.TurnOn();                             // turn on the devices using overriden abstract method of 'Device' abstract class
            polaroid1.TurnOn();
            printer1.TurnOn();

            phone.TakePhoto();                          // take photo using overriden method of interface 'ITakePhoto'
            polaroid1.TakePhoto();

            polaroid2.Print();                          // output of data returning by method 'Print()' of interface 'IPrint'
            printer2.Print();

            Console.WriteLine();       // добавила перевод строки чтобы красивее выводилось

            phone.TunrnOff();                  // turn off the deviced using method of the 'Device' class
            polaroid1.TunrnOff();
            printer1.TunrnOff();
        }
    }
}
