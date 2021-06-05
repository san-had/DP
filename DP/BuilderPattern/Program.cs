using System;
using BuilderPattern.Builder;
using BuilderPattern.ConcreteBuilders;
using BuilderPattern.Director;

namespace BuilderPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Manufacturer manufacturer = new Manufacturer();

            IPhoneBuilder phoneBuilder = null;

            phoneBuilder = new AndroidPhoneBuilder();
            manufacturer.Construct(phoneBuilder);
            Console.WriteLine("A new Phone built:\n\n{0}", phoneBuilder.Phone.ToString());

            phoneBuilder = new WindowsPhoneBuilder();
            manufacturer.Construct(phoneBuilder);
            Console.WriteLine("A new Phone built:\n\n{0}", phoneBuilder.Phone.ToString());
        }
    }
}