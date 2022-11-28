﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;

namespace Hometask_Lec7
{
    public class Base
    {
        //static void Main()
        //{
        //    Dolphin Goober = new Dolphin("dolphin", "Goobby", 3, false, "Yes");                       // creating dolphin Goober
        //    Cat Murzik = new Cat("cat", "Chuchelo Miauchelo", 5, true, "short");                      // creating cat Murzik

        //    Console.WriteLine(Goober.AnimalData);                                                     // return the main data of dolphin Goober
        //    Console.WriteLine(Murzik.AnimalData + "\n****************\n");                            // return the main data of cat Murzik

        //    Goober.AnimalData = "Definitely yes!!!";                                                  // setting a new value to the dolphin's Goober parameter "canSwim"
        //    Murzik.AnimalData = "long";                                                               // setting a new value to the cat's Murzik parameter "coatLength"

        //    Console.WriteLine(Goober.AnimalData);                                                     // return the edited data of dolphin Goober
        //    Console.WriteLine(Murzik.AnimalData + "\n****************\n");                            // return the edited data of cat Mursik

        //    Console.WriteLine(Dolphin.Feed(Goober.Nickname, Goober.isHungry));                        // Feeded dolphin Goober
        //    Console.WriteLine(Cat.Feed(Murzik.Nickname, Murzik.isHungry) + "\n****************\n");   // Feeded cat Murzik
             
        //    Console.WriteLine(Goober.SayHelloToTheAnimal(Goober.Nickname));                           // saying hello to Goober
        //    Console.WriteLine(Murzik.SayHelloToTheAnimal(Murzik.Nickname) + "\n****************\n");  // saying hello to Murzik
                                                              
        //    Console.WriteLine(Dolphin.Swim(Goober.Nickname));                                         // Dolphin Goober is swimmig
        //    Console.WriteLine(Cat.CatIsShedding(Murzik.Nickname) + "\n****************\n");           // Мурзик линяет
        //}
    }

    public abstract class Mammal                                                 // млекопитающие
    {
        public string KindOfAnimal;                                              // fields of the abstract class

        public string Nickname;
        public int Age;
        public bool isHungry;

        public Mammal(string kindOfAnimal, string nickname, int age, bool isHungry)        // set initial object values data
        {
            this.KindOfAnimal = kindOfAnimal;
            this.Nickname = nickname;
            this.Age = age;
            this.isHungry = isHungry;
        }

        public abstract string AnimalData { get; set; }                            // abstract getter and setter

        public static string Feed(string petName, bool isHungry)                   // feed pet if the pet is hungry
        {
            string s = (isHungry)? $"{petName} is feeded!" : $"{petName} is not hungry.";
            return s;
        }
        
        public abstract string SayHelloToTheAnimal(string petName);               // abstract method, is overriden below
    }

    public class Dolphin : Mammal
    {
        private string sweemLikeACoolDolphin;                                                   // field of the class

        public Dolphin(string kindOfAnimal, string nickname, int age, bool isHungry, string canSwim) : base(kindOfAnimal, nickname, age, isHungry)       // set initial object parameters' values overriding method of the abstract class
        {
            this.sweemLikeACoolDolphin = canSwim;
        }

        public override string AnimalData
        {
            get { return $"Kind of anomal: {KindOfAnimal}, Nickname: {Nickname}, Age: {Age}, Can the animal swim? {sweemLikeACoolDolphin}"; }           // getting a dolphin's main data
            set { sweemLikeACoolDolphin = value; }                                                                                                      // setting the value of a dolpin's parameter "canSwin"
        }

        public override string SayHelloToTheAnimal(string petName)                            // dolphin says hello
        {
            return $"- Hello, {petName}. \n- trrrrrrrrr! ";
        }

        public static string Swim(string petName)                                            // dolphin is swimming
        {
            return $"{petName} is swimming!";
        }
    }

    public class Cat : Mammal
    {
        private string coatLength;                                                 // field of the class

        public Cat(string kindOfAnimal, string nickname, int age, bool isHungry, string coatLength) : base(kindOfAnimal, nickname, age, isHungry)        // set initial object parameters' values overriding method of the abstract class
        {
            this.coatLength = coatLength;
        }

        public override string AnimalData
        {
            get { return $"Kind of anomal: {KindOfAnimal}, Nickname: {Nickname}, Age: {Age}, Coat Length: {coatLength}"; }         // getting the cat's main data
            set { coatLength = value; }                                                                                            // setting the value of a cat's parameter "coatLength"
        }

        public override string SayHelloToTheAnimal(string petName)                 // cat says hello
        {
            return $"- Hello, {petName}. \n- Meoy! ";
        }

        public static string CatIsShedding(string petName)                         // метод "кот линяет"
        {
            return $"{petName} linyaet! =(";
        }
    }
}
