namespace Builder.Model
{
    public class SaladTopping : ITopping
    {
        public string Name { get; } = "Салат";
        public int Value { get; } = 2;
    }

    public class TomatoTopping : ITopping
    {
        public string Name { get; } = "Помидор";
        public int Value { get; } = 4;
    }

    public class CheeseTopping : ITopping
    {
        public string Name { get; } = "Сыр";
        public int Value { get; } = 6;
    }

    public class ChickenTopping : ITopping
    {
        public string Name { get; } = "Курица";
        public int Value { get; } = 8;
    }
}