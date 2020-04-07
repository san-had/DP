using System;

namespace ChainOfResponsibility
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var user = new User
            {
                Name = "Filip Ekberg",
                SocialCode = "870101XXXX",
                RegionInfo = "SE",
                DateOfBirth = new DateTime(1987, 1, 29)
            };

            var processor = new UserProcessor();

            var result = processor.Register(user);

            Console.WriteLine(result);
        }
    }
}