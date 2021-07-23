using System;
using DAL;

namespace CodeStarProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var context = new Context();
            context.Print();
        }
    }
}
