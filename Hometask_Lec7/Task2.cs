using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_Lec7
{
    public class BaseClass
    {
        //static void Main()
        //{
        //    IWalk Burionka = new Cow();                 // initialization of objects
        //    Cow Glasha = new Cow();
        //    IWalk Sharik = new Dog();
        //    Dog Bobik = new Dog();
        //    Fish Nemo = new Fish();
        //    Bird Kesha = new Bird();
        //    Butterfly Tipster = new Butterfly();

        //    Console.WriteLine(Glasha.MakeSound());     // output of data returning by method 'MakeSound()' for cow
        //    Console.WriteLine(Bobik.MakeSound());      // output of data returning by method 'MakeSound()' for dog
        //    Console.WriteLine(Kesha.MakeSound());      // output of data returning by method 'MakeSound()' for bird

        //    Burionka.Speed();                          // output of data returning by method 'Speed()' of interface 'IFly'
        //    Sharik.Speed();                            // output of data returning by method 'Speed()' of interface 'IFly'
        //    Console.WriteLine(Glasha.Walk());          // output of data returning by method 'Walk()' for cow
        //    Console.WriteLine(Bobik.Walk());           // output of data returning by method 'Walk()' for cow

        //    Console.WriteLine(Bobik.Swim());           // output of data returning by method 'Swim()' for the dog
        //    Console.WriteLine(Bobik.SwimmingStyle);    // getter retuns the swimming style of the dog
        //    Console.WriteLine(Nemo.Swim());            // output of data returning by method 'Swim()' for the fish
        //    Console.WriteLine(Nemo.SwimmingStyle);     // getter retuns the swimming style of the fish

        //    Console.WriteLine(Kesha.Fly(Kesha.Direction));      // output of data returning by method 'Fly()' for the bird
        //    Console.WriteLine(Tipster.Fly(Tipster.Direction));  // output of data returning by method 'Fly()' for the butterfly
        //}
    }
    interface IMakeSound
    {
        string MakeSound();                 // the method is overriden below
    }

    interface IWalk
    {
        public const int MinSpeed = 0;     // the interface fields
        public static int MaxSpeed = 15;

        void Speed()             // method returns max and min speed
        {
            Console.WriteLine("Maximum speed is " + MaxSpeed + " kilometers per hour. " + "Minimum speed is " + MinSpeed + " kilometers per hour.");
        }

        string Walk();                       // the method is overriden below
    }

    interface ISwim
    {
        public string SwimmingStyle { get; }     // getting swimming style of an object
        public string Swim();                    // the method is overriden below
    }

    interface IFly
    {
        string Direction { get; }                // getting the direction of an object

        public string Fly(string direction);     // the method is overriden below
    }

    public class Cow: IMakeSound, IWalk
    {
        public string MakeSound()                                // overriding method 'MakeSound' of interface 'IMakeSound'
        {
            return "Muuu!";
        }
        public string Walk()                                     // overriding method 'Walk' of interface 'IWalk'
        {
            return "The cow is walking.";
        }
    }

    public class Dog: IMakeSound, IWalk, ISwim
    {
        public string MakeSound()                                // overriding method 'MakeSound' of interface 'IMakeSound'
        {
            return "Gav-gav!";
        }

        public string Walk()                                     // overriding method 'Walk' of interface 'IWalk'
        {
            return "The dog is walking.\n";
        }

        public string SwimmingStyle { get { return $"The dog uses doggy swim style!\n"; } }      // getter returns swimming style of a dog; overrides method 'SwimmingStyle' of interface 'ISwim'
        public string Swim()                           // overriding method 'Swim' of interface 'ISwim'
        {
            return "The dog is swimming!";
        }
    }

    public class Fish: ISwim
    {
        public string SwimmingStyle { get { return $"I'm just a fish, so I swim as I can.\n"; } }    // getter returns swimming style of fish; overrides method 'SwimmingStyle' of interface 'ISwim'

        public string Swim()                       // overriding method 'Swim' of interface 'ISwim'
        {
            return "The fish is swimming!";
        }  
    }

    public class Bird: IMakeSound, IFly
    {
        public string MakeSound()                                // overriding method MakeSound of interface IMakeSound
        {
            return "Chik-chirik!\n";
        }
        public string Direction { get { return "to warmer climes"; } }   // getter returns direction of a bird; overrides method 'Direction' of interface 'IFly'

        public string Fly(string direction)    // overriding method Fly of interface IFly
        {
            return $"Flying {direction}!";
        }
    }

    public class Butterfly: IFly  
    {
        public string Direction { get { return "to the beautiful flowers"; } }   // getter returns direction of a butterfly; overrides method 'Direction' of interface 'IFly'

        public string Fly(string direction)   // overriding method Fly of interface IFly
        {
            return $"Flying {direction}! \n";
        }
    }
}
