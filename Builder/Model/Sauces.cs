namespace Builder.Model
{
    public class Ketchup : ISauceType
    {
        public string Name { get; } = "Кетчуп";
        public int Value { get; } = 8;
    }

    public class Mayonnaise : ISauceType
    {
        public string Name { get; } = "Майонез";
        public int Value { get; } = 10;
    }
}