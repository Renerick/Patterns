using System;
using System.Collections.Generic;

namespace Builder.Model
{
    public class SandwichBuilder : ISandwichBuilder
    {
        private readonly List<ITopping> _toppings = new List<ITopping>();
        private          IBreadType     _breadType;
        private          ISauceType     _sauceType;

        public Sandwich Cook()
        {
            if (_breadType == null)
                throw new Exception("Bread Type can't be null");
            return new Sandwich(_breadType, _sauceType, _toppings);
        }

        public void SetBreadType(IBreadType breadType)
        {
            _breadType = breadType;
        }

        public void SetSauceType(ISauceType sauceType)
        {
            _sauceType = sauceType;
        }

        public void AddTopping(ITopping topping)
        {
            _toppings.Add(topping ?? throw new ArgumentNullException());
        }

        public void Reset()
        {
            _toppings.Clear();
            _breadType = null;
            _sauceType = null;
        }
    }
}