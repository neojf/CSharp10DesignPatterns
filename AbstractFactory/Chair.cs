namespace AbstractFactory
{
    public interface Chair
    {
        string Name { get; }

        void DoChairthings();
    }

    public class VictorianChair : Chair
    {
        public string Name => "Victorian Chair";

        public void DoChairthings()
        {
            Console.WriteLine($"This is {Name}");
        }
    }

    public class ArtDecoChair : Chair
    {
        public string Name => "Art Deco Chair";

        public void DoChairthings()
        {
            Console.WriteLine($"This is {Name}");
        }
    }

    public class ModernChair : Chair
    {
        public string Name => "Modern Chair";

        public void DoChairthings()
        {
            Console.WriteLine($"This is {Name}");
        }
    }
}
