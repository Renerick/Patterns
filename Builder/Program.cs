using System;
using System.Collections.Generic;
using Builder.Model;

namespace Builder
{
    static class Program
    {
        static void Main(string[] args)
        {
            var sandvich = new Sandwich
            {
                Topings = new List<IToping> {null, new SaladToping()},
                BreadType = new RyeBread()
            };
            Console.WriteLine(sandvich.ToString());
        }
    }
}