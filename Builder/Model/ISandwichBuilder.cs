namespace Builder.Model
{
    public interface ISandwichBuilder
    {
        Sandwich Cook();
        void SetBreadType(IBreadType breadType);
        void SetSauceType(ISauceType sauceType);
        void AddTopping(ITopping topping);
    }
}