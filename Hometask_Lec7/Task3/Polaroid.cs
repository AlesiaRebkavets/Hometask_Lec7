using Hometask_Lec7.Task3;
using System.Threading.Tasks;

namespace Hometask_Lec7
{
    public class Polaroid: PrintingDevice, IPrint, ITakePhoto
    {
        private int paperWidth;
        private int paperHeight;
        private double numberOfPixelsInCamera;

        public Polaroid(string modelName, decimal price, int paperWidth, int paperHeight, double numberOfPixelsInCamera): base(modelName, price, paperWidth, paperHeight)    // set initial object parameters' values overriding method of the abstract class
        {
            this.numberOfPixelsInCamera = numberOfPixelsInCamera;
        }

        public override string Description                        // getting polaroid's price, model name and number of pixels in camera
        {
            get
            {
                return $"Price: {price}, model: {modelName}, number of pixels in camera: {numberOfPixelsInCamera}";
            }
        }

        public void TakePhoto()
        {
            Console.WriteLine("Press black button at the top and photo is ready\n");  // overloaded method of interface 'ITakePhoto'
        }

        public override void TurnOn()                                 // overloaded method to turn on the device
        {
            Console.WriteLine("Press right side button");
        }
    }
}
