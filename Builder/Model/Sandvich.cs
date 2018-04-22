using System.Collections.Generic;
using System.Linq;

namespace Builder.Model
{
    public class Sandwich
    {
        public List<IToping> Topings { get; set; }
        public IBreadType BreadType { get; set; }

        public override string ToString() => 
            $"Это сэндвич. Он сделан на основе {BreadType.Name} и содержит\n{string.Join(",\n", Topings.Select(t => t.Name))}\n" +
            $"Его пищевая ценность: {Topings.Sum(toping => toping.Value) + BreadType.Value}";
    }

    public interface ISandvichComponent
    {
        string Name { get; } 
        int Value { get; }
    }

    public interface IBreadType : ISandvichComponent
    {
    }

    public interface IToping : ISandvichComponent
    {
    }
}