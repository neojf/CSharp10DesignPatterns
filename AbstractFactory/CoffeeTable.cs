namespace AbstractFactory
{
    public interface CoffeeTable
    {
        string Name { get; }
        void DoCoffeeTablethings();
    }

    public class VictorianCoffeeTable : CoffeeTable
    {
        public string Name => "Victorian CoffeeTable";

        public void DoCoffeeTablethings()
        {
            Console.WriteLine($"This is {Name}");
        }
    }

    public class ArtDecoCoffeeTable : CoffeeTable
    {
        public string Name => "Art Deco CoffeeTable";

        public void DoCoffeeTablethings()
        {
            Console.WriteLine($"This is {Name}");
        }
    }

    public class ModernCoffeeTable : CoffeeTable
    {
        public string Name => "Modern CoffeeTable";

        public void DoCoffeeTablethings()
        {
            Console.WriteLine($"This is {Name}");
        }
    }
}
