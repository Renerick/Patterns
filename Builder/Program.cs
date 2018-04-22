using System;
using Builder.Model;

namespace Builder
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            ISandwichBuilder builder = new SandwichBuilder();
            builder.AddTopping(new CheeseTopping());
            builder.AddTopping(new SaladTopping());
            builder.SetBreadType(new RyeBread());
            Console.WriteLine(builder.Cook());
        }
    }
}