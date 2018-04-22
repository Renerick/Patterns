using System;
using System.Collections.Generic;
using Builder.Model;

namespace Builder
{
    static class Program
    {
        static void Main(string[] args)
        {
            var sandwich = new Sandwich(new RyeBread());
            sandwich.AddTopping(new CheeseTopping());
            sandwich.AddTopping(new ChickenTopping());
            sandwich.AddTopping(new SaladTopping());
            Console.WriteLine(sandwich.ToString());
        }
    }
}