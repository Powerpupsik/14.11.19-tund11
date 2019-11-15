using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogBreedEnum1
{
    //ENUM
    enum Breed
    {
        Bulldog,
        Boxer,
        Chihauha
    }
    class Dog
    {
        public static int Count = 0;
        public string name;
        public int age;
        public Breed breed;

        public Dog(string _name, int _age, Breed _breed)
        {
            name = _name;
            age = _age;
            breed = _breed;
            Count++;
        }

        public void PrintDogInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Breed: {breed}");


        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            
            Dog sass = new Dog("Sass", 10, Breed.Chihauha);
            sass.PrintDogInfo();

            Dog muri = new Dog("Muki", 2, Breed.Boxer);
            muri.PrintDogInfo();

            Console.WriteLine($"You have {Dog.Count} dog(s)");

            Console.ReadLine();


        }
    }
}
