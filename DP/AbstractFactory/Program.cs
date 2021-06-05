using System;

namespace AbstractFactory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            AbstractFactory factory1 = new ConcreteFactory1();
            Client client1 = new Client(factory1);
            client1.Run();

            AbstractFactory factory2 = new ConcreteFactory2();
            Client client2 = new Client(factory2);
            client2.Run();
        }
    }

    internal abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();

        public abstract AbstractProductB CreateProductB();
    }

    internal class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }

    internal class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }

    internal abstract class AbstractProductA
    {
    }

    internal abstract class AbstractProductB
    {
        public abstract void Interact(AbstractProductA abstractProductA);
    }

    internal class ProductA1 : AbstractProductA
    {
    }

    internal class ProductA2 : AbstractProductA
    {
    }

    internal class ProductB1 : AbstractProductB
    {
        public override void Interact(AbstractProductA abstractProductA)
        {
            Console.WriteLine(this.GetType().Name + " interact with " + abstractProductA.GetType().Name);
        }
    }

    internal class ProductB2 : AbstractProductB
    {
        public override void Interact(AbstractProductA abstractProductA)
        {
            Console.WriteLine(this.GetType().Name + " interact with " + abstractProductA.GetType().Name);
        }
    }

    internal class Client
    {
        private AbstractProductA abstractProductA;
        private AbstractProductB abstractProductB;

        public Client(AbstractFactory factory)
        {
            abstractProductB = factory.CreateProductB();
            abstractProductA = factory.CreateProductA();
        }

        public void Run()
        {
            abstractProductB.Interact(abstractProductA);
        }
    }
}