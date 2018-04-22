using System;
using Builder.Model;

namespace Builder
{
    static class Program
    {
        static void Main(string[] args)
        {
            var sandwich1 = new Sandwich(new RyeBread(), null);
            sandwich1.AddTopping(new CheeseTopping());
            sandwich1.AddTopping(new ChickenTopping());
            sandwich1.AddTopping(new SaladTopping());
            Console.WriteLine(sandwich1.ToString());
            Console.WriteLine();
            
            var sandwich2 = new Sandwich(new WhiteBread(), new Ketchup());
            sandwich2.AddTopping(new CheeseTopping());
            sandwich2.AddTopping(new SaladTopping());
            Console.WriteLine(sandwich2.ToString());
        }
    }
}