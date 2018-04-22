using System.Collections.Generic;
using System.Linq;

namespace Builder.Model
{
    public class Sandwich
    {
        private readonly IBreadType     _breadType;
        private readonly ISauceType     _sauceType;
        private readonly List<ITopping> _toppings;

        public Sandwich(IBreadType breadType, ISauceType sauceType, List<ITopping> toppings)
        {
            _breadType = breadType;
            _toppings = toppings;
            _sauceType = sauceType;
        }

        public int Value => _toppings.Sum(toping => toping.Value) + _breadType.Value + (_sauceType?.Value ?? 0);

        public override string ToString()
        {
            return
                $"Это сэндвич. Он сделан на основе {_breadType.Name} и содержит\n{string.Join(",\n", _toppings.Select(t => t.Name))}\n" +
                $"Его пищевая ценность: {Value}" + (_sauceType != null ? $"\nСодержит {_sauceType.Name}" : "");
        }
    }

    public interface ISandwichComponent
    {
        string Name { get; }
        int Value { get; }
    }

    public interface IBreadType : ISandwichComponent
    {
    }

    public interface ITopping : ISandwichComponent
    {
    }

    public interface ISauceType : ISandwichComponent
    {
    }
}