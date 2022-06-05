namespace AbstractFactory
{
    public interface Sofa
    {
        string Name { get; }
        void DoSofathings();
    }

    public class VictorianSofa : Sofa
    {
        public string Name => "Victorian Sofa";

        public void DoSofathings()
        {
            Console.WriteLine($"This is {Name}");
        }
    }

    public class ArtDecoSofa : Sofa
    {
        public string Name => "Art Deco Sofa";

        public void DoSofathings()
        {
            Console.WriteLine($"This is {Name}");
        }
    }

    public class ModernSofa : Sofa
    {
        public string Name => "Modern Sofa";

        public void DoSofathings()
        {
            Console.WriteLine($"This is {Name}");
        }
    }
}
