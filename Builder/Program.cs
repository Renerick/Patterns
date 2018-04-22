using System;
using System.Runtime.InteropServices;
using Builder.Model;

namespace Builder
{
    internal static class Program
    {
        private static void Main()
        {
            var sandwich = new SandwichBuilder().SetBreadType(new RyeBread())
                                                .AddTopping(new TomatoTopping())
                                                .AddTopping(new ChickenTopping())
                                                .SetSauceType(new Ketchup())
                                                .Cook();
            Console.WriteLine(sandwich.ToString());
        }
    }
}