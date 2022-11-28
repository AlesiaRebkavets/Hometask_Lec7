using Hometask_Lec7.Task3;
using System.Threading.Tasks;

namespace Hometask_Lec7
{
    public class Printer: PrintingDevice, IPrint
    {
        private int paperWidth;
        private int paperHeight;

        public Printer(string modelName, decimal price, int paperWidth, int paperHeight): base(modelName, price, paperWidth, paperHeight) { }    // set initial object parameters' values overriding method of the abstract class

        public override string Description              // getting printer's price and model name 
        {
            get
            {
                return $"Price: {price}, model: {modelName} \n";
            }
        }

        public override void TurnOn()                           // overloaded method to turn on the device
        {
            Console.WriteLine("Press button at the top\n");
        }       
    }

}