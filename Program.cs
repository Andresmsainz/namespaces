using System;

namespace Namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Namespaces!");

            MyCustomNamespace.Animal animal = new MyCustomNamespace.Animal();
            animal.SayHi();
        }
    }
}

namespace MyCustomNamespace
{
    class Animal
    {
        public string animalColor;

        public void SayHi()
        {
            Console.WriteLine("Hi From the custom namespace");
        }
    }
}