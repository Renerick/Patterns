using System;
using System.Collections.Generic;
using System.Linq;

namespace Builder.Model
{
    public class Sandwich
    {
        private readonly List<ITopping> _toppings;
        private readonly IBreadType _breadType;

        public Sandwich(IBreadType breadType)
        {
            _breadType = breadType ?? throw new ArgumentNullException(nameof(breadType));
            _toppings = new List<ITopping>();
        }

        public void AddTopping(ITopping topping)
        {
            _toppings.Add(topping ?? throw new ArgumentNullException());
        }

        public override string ToString() => 
            $"Это сэндвич. Он сделан на основе {_breadType.Name} и содержит\n{string.Join(",\n", _toppings.Select(t => t.Name))}\n" +
            $"Его пищевая ценность: {_toppings.Sum(toping => toping.Value) + _breadType.Value}";
    }

    public interface ISandvichComponent
    {
        string Name { get; } 
        int Value { get; }
    }

    public interface IBreadType : ISandvichComponent
    {
    }

    public interface ITopping : ISandvichComponent
    {
    }
}