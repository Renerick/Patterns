namespace Builder.Model
{
    public class SandwichDirector
    {
        public Sandwich MakeVeganSandwich(ISandwichBuilder builder)
        {
            builder.Reset();
            builder.SetBreadType(new RyeBread());
            builder.SetSauceType(new Ketchup());
            builder.AddTopping(new SaladTopping());
            builder.AddTopping(new TomatoTopping());
            return builder.Cook();
        }

        public Sandwich MakeSimpleSandwich(ISandwichBuilder builder)
        {
            builder.Reset();
            builder.SetBreadType(new WhiteBread());
            builder.AddTopping(new ChickenTopping());
            builder.AddTopping(new CheeseTopping());
            builder.AddTopping(new SaladTopping());
            builder.SetSauceType(new Mayonnaise());
            return builder.Cook();
        }
    }
}