using System;
using System.Collections.Generic;

namespace VisitorDesignPattern
{
    internal class Program
    {
        private static void Main()
        {
            List<Kid> dayCare = new List<Kid>();

            Kid Elizabeth = new Kid();
            Elizabeth.Name = "Elizabeth";
            Elizabeth.Age = 3;
            dayCare.Add(Elizabeth);

            Kid Aimee = new Kid();
            Aimee.Name = "Aimee";
            Aimee.Age = 4;
            dayCare.Add(Aimee);

            List<Visitor> visitors = new List<Visitor>();
            visitors.Add(new EyeDoctor());
            visitors.Add(new SLP());
            visitors.Add(new Parent());

            foreach (Visitor visitor in visitors)
            {
                foreach (Kid oneKid in dayCare)
                {
                    oneKid.AcceptVisitor(visitor);
                }
            }

            foreach (Kid oneKid in dayCare)
            {
                Console.WriteLine("Display Status for " + oneKid.Name);
                Console.WriteLine(oneKid.EyeStatus);
                Console.WriteLine(oneKid.SpeechStatus);
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}