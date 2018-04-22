namespace Builder.Model
{
    public class SaladToping : IToping
    {
        public string Name { get; } = "Салат";
        public int Value { get; } = 2;
    }

    public class TomatoToping : IToping
    {
        public string Name { get; } = "Помидор";
        public int Value { get; } = 4;
    }

    public class CheeseToping : IToping
    {
        public string Name { get; } = "Сыр";
        public int Value { get; } = 6;
    }

    public class ChickenToping : IToping
    {
        public string Name { get; } = "Курица";
        public int Value { get; } = 8;
    }
}