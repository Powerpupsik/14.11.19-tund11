using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogConstructor2
{
    class Animal
    {
        public static int Count = 0; //LOEB, MITU KLASSI ON LOODUD.OLENEB, MIS KLASSI SA SELLE LOOD VEEL.


        public string name;
        public string color;

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Color: {color}");
        }
    }
        class Dog : Animal
        {
            public string breed;
            public Dog(string _name, string _color, string _breed) //KONSTRUKTOR
            {
                name = _name;
                color = _color;
                breed = _breed;

                Count++;
            }

           public void PrintInfoAboutDog()
           {
            Console.WriteLine($"Dog's name: {name}");
            Console.WriteLine($"Dog's color: {color}");
            Console.WriteLine($"Dog's breed: {breed}");


           }



    }
        class Program
        {
            static void Main(string[] args)
            {
                Dog rex = new Dog("Rex", "black and white", "bulldog"); //JÄRJEKORD OLULINE!!!
            rex.PrintInfoAboutDog();

            Console.WriteLine($"{Animal.Count} has/have been created");
                Console.ReadLine();
            }
        }
       }
