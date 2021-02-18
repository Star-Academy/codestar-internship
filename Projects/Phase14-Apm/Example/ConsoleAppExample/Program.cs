using System;
using ConsoleAppExample.Businesses;
using Elastic.Apm;

namespace ConsoleAppExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number Of businesses to run");
            var businessCount = int.Parse(Console.ReadLine());
            var businessRepository = new BusinessRepository();
            var rng = new Random();

            for (int i = 0; i < businessCount; i++)
            {
                var businessType = rng.Next(1, 4);
                string result = "";
                switch (businessType)
                {
                    case 1:
                        result = businessRepository.SmallBusiness();
                        break;
                    case 2:
                        result = businessRepository.MediumBusiness();
                        break;
                    case 3:
                        result = businessRepository.Longbusiness();
                        break;
                }

                Console.WriteLine(result);
            }
        }
    }
}