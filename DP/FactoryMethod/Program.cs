using System;

namespace FactoryMethod
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var factory = new Factory();

            var product1 = factory.CreateProduct(1);
            product1.ShowInfo();
            var product2 = factory.CreateProduct(2);
            product2.ShowInfo();
        }
    }

    internal interface IFactory
    {
        ProductBase CreateProduct(int type);
    }

    public class Factory : IFactory
    {
        public ProductBase CreateProduct(int type)
        {
            switch (type)
            {
                case 1:
                    return new ConcreteProduct1();

                case 2:
                    return new ConcreteProduct2();

                default:
                    throw new ArgumentException(string.Format("Invalid type: {0}", type));
            }
        }
    }

    public abstract class ProductBase
    {
        public abstract void ShowInfo();
    }

    public class ConcreteProduct1 : ProductBase
    {
        public override void ShowInfo()
        {
            Console.WriteLine("Product1");
        }
    }

    public class ConcreteProduct2 : ProductBase
    {
        public override void ShowInfo()
        {
            Console.WriteLine("Product2");
        }
    }
}