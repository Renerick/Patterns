using System;
using System.Runtime.InteropServices;
using Builder.Model;

namespace Builder
{
    internal static class Program
    {
        private static void Main()
        {
            var director = new SandwichDirector();
            var builder = new SandwichBuilder();
            Console.WriteLine(director.MakeVeganSandwich(builder));
            Console.WriteLine();
            Console.WriteLine(director.MakeSimpleSandwich(builder));
        }
    }
}