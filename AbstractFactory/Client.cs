namespace AbstractFactory
{
    public class Client
    {
        private readonly FurnitureFactory factory;

        public Client(FurnitureFactory factory)
        {
            this.factory = factory;
        }

        public void DoSomeOperation()
        {
            Chair chair = this.factory.createChair();
            chair.DoChairthings();

            CoffeeTable coffeeTable = this.factory.createCoffeeTable();
            coffeeTable.DoCoffeeTablethings();

            Sofa sofa = this.factory.createSofa();
            sofa.DoSofathings();
        }
    }
}
