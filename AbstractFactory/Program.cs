using AbstractFactory;

Console.Title = "Abstract Factory";

FurnitureFactory factory = new VictorianFurnitureFactory();
Client client = new Client(factory);
client.DoSomeOperation();
Console.WriteLine("***********************************");

FurnitureFactory factory1 = new ArtDecoFurnitureFactory();
Client client1 = new Client(factory1);
client1.DoSomeOperation();
Console.WriteLine("***********************************");

FurnitureFactory factory2 = new ModernFurnitureFactory();
Client client2 = new Client(factory2);
client1.DoSomeOperation();
Console.WriteLine("***********************************");