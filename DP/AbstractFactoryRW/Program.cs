using System;

namespace AbstractFactoryRW
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var seaAnimalFactory = AnimalFactory.CreateAnimalFactory("Sea");
            Console.WriteLine("Animal Factory type : " + seaAnimalFactory.GetType().Name);
            Console.WriteLine();

            var seaAnimal = seaAnimalFactory.GetAnimal("Octopus");
            Console.WriteLine("Animal Type : " + seaAnimal.GetType().Name);
            var speakSound = seaAnimal.Speak();
            Console.WriteLine(seaAnimal.GetType().Name + " Speak : " + speakSound);
            Console.WriteLine();

            Console.WriteLine("--------------------------");
            var landAnimalFactory = AnimalFactory.CreateAnimalFactory("Land");
            Console.WriteLine("Animal Factory type : " + landAnimalFactory.GetType().Name);
            Console.WriteLine();

            var landAnimal = landAnimalFactory.GetAnimal("Lion");
            Console.WriteLine("Animal Type : " + landAnimal.GetType().Name);
            speakSound = landAnimal.Speak();
            Console.WriteLine(landAnimal.GetType().Name + " Speak : " + speakSound);
            Console.WriteLine();

            landAnimal = landAnimalFactory.GetAnimal("Cat");
            Console.WriteLine("Animal Type : " + landAnimal.GetType().Name);
            speakSound = landAnimal.Speak();
            Console.WriteLine(landAnimal.GetType().Name + " Speak : " + speakSound);
        }
    }

    internal abstract class AnimalFactory
    {
        public abstract IAnimal GetAnimal(string animalType);

        public static AnimalFactory CreateAnimalFactory(string factoryType)
        {
            switch (factoryType)
            {
                case "Sea":
                    return new SeaAnimalFactory();

                case "Land":
                    return new LandAnimalFactory();

                default:
                    throw new ArgumentException(string.Format("Invalid factoryType parameter: {0}", factoryType));
            }
        }
    }

    internal class LandAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(string animalType)
        {
            switch (animalType)
            {
                case "Dog":
                    return new Dog();

                case "Cat":
                    return new Cat();

                case "Lion":
                    return new Lion();

                default:
                    throw new ArgumentException(string.Format("Invalid animalType parameter: {0}", animalType));
            }
        }
    }

    internal class SeaAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(string animalType)
        {
            switch (animalType)
            {
                case "Shark":
                    return new Shark();

                case "Octopus":
                    return new Octopus();

                default:
                    throw new ArgumentException(string.Format("Invalid animalType parameter: {0}", animalType));
            }
        }
    }

    internal interface IAnimal
    {
        string Speak();
    }

    internal class Cat : IAnimal
    {
        public string Speak()
        {
            return "Meow Meow Meow";
        }
    }

    internal class Lion : IAnimal
    {
        public string Speak()
        {
            return "Roar";
        }
    }

    internal class Dog : IAnimal
    {
        public string Speak()
        {
            return "Bark bark";
        }
    }

    internal class Octopus : IAnimal
    {
        public string Speak()
        {
            return "SQUAWCK";
        }
    }

    internal class Shark : IAnimal
    {
        public string Speak()
        {
            return "Cannot Speak";
        }
    }
}