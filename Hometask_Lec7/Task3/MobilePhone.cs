using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_Lec7
    {
        public class MobilePhone
        {
            private double numberOfPixelsInCamera;
            private string? modelName;
            private decimal price;

            public MobilePhone(double numberOfPixelsInCamera, string? modelName, decimal price)
            {
                this.numberOfPixelsInCamera = numberOfPixelsInCamera;
                this.modelName = modelName;
                this.price = price;
            }

            public string Description
            {
                get
                {
                    return $"Price: {price}, model:{modelName}, number of pixels in camera: {numberOfPixelsInCamera}";
                }
            }

            public void TakePhoto()
            {
                Console.WriteLine("Press button on the screen and photo is ready");
            }

            public void TurnOn()
            {
                Console.WriteLine("Press left side button");
            }

            public void TunrnOff()
            {
                Console.WriteLine("Press Turn Off button");
            }
        }
    }
