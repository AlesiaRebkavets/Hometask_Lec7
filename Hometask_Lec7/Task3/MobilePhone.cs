using Hometask_Lec7.Task3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_Lec7
    {
        public class MobilePhone: Device, ITakePhoto
        {
            private double numberOfPixelsInCamera;

            public MobilePhone(string modelName, decimal price, double numberOfPixelsInCamera): base(modelName, price)   // set initial object parameters' values overriding method of the abstract class
            {
                this.numberOfPixelsInCamera = numberOfPixelsInCamera;
            }

            public override string Description => $"Price: {price}, model: {modelName}, number of pixels in camera: {numberOfPixelsInCamera}"; 
                                                                          // getting mobile phone's price, model name and number of pixels in camera

            public void TakePhoto()                                                     // overloaded method of interface 'ITakePhoto'
        {
                Console.WriteLine("Press button on the screen and photo is ready");
            }

            public override void TurnOn()                               // overloaded method to turn on the device
        {
                Console.WriteLine("Press left side button");
            }           
        }
    }
