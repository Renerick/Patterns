namespace Builder.Model
{
    public class RyeBread : IBreadType
    {
        public string Name { get; } = "Ржаной хлеб";
        public int Value { get; } = 10;
    }

    public class WhiteBread : IBreadType
    {
        public string Name { get; } = "Белый хлеб";
        public int Value { get; } = 20;
    }
}