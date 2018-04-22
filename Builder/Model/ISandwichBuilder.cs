namespace Builder.Model
{
    public interface ISandwichBuilder
    {
        Sandwich Cook();
        ISandwichBuilder SetBreadType(IBreadType breadType);
        ISandwichBuilder SetSauceType(ISauceType sauceType);
        ISandwichBuilder AddTopping(ITopping topping);
        ISandwichBuilder Reset();
    }
}