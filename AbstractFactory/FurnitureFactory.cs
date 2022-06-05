namespace AbstractFactory
{
    public interface FurnitureFactory
    {
        Chair createChair();
        CoffeeTable createCoffeeTable();
        Sofa createSofa();
    }

    public class VictorianFurnitureFactory : FurnitureFactory
    {
        public Chair createChair()
        {
            return new VictorianChair();
        }

        public CoffeeTable createCoffeeTable()
        {
            return new VictorianCoffeeTable();
        }

        public Sofa createSofa()
        {
            return new VictorianSofa();
        }
    }

    public class ArtDecoFurnitureFactory : FurnitureFactory
    {
        public Chair createChair()
        {
            return new ArtDecoChair();
        }

        public CoffeeTable createCoffeeTable()
        {
            return new ArtDecoCoffeeTable();
        }

        public Sofa createSofa()
        {
            return new ArtDecoSofa();
        }
    }

    public class ModernFurnitureFactory : FurnitureFactory
    {
        public Chair createChair()
        {
            return new ModernChair();
        }

        public CoffeeTable createCoffeeTable()
        {
            return new ModernCoffeeTable();
        }

        public Sofa createSofa()
        {
            return new ModernSofa();
        }
    }
}
