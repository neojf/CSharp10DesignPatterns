using FactoryMethod;

Console.Title = "Factory Method";

////// For country discount shop, total price is 500 Yuan.
////double rawPrice = 500;
////Shop shop = new CountryDiscountShop("CN");
////Console.WriteLine(shop.Welcome());

////var newPrice = shop.CalcutePrice(rawPrice);
////Console.WriteLine($"Raw price: {rawPrice}, new price after discount: {newPrice}");

////// For code discount shop, total price is 200 Yuan.
////double rawPrice2 = 500;
////Shop shop2 = new CodeDiscountShop(Guid.NewGuid());
////Console.WriteLine(shop2.Welcome());
////var newPrice2 = shop2.CalcutePrice(rawPrice2);
////Console.WriteLine($"Raw price: {rawPrice2}, new price after discount: {newPrice2}");
////Console.ReadKey();

// Order a cheese pizza in NY pizza store
PizzaStore pizzaStore = new NYStylePizzaStore();
Pizza pizza = pizzaStore.orderPizza("cheese");

Console.WriteLine("-----------------------------------");

// Order a veggie pizza in Chicago pizza store
PizzaStore pizzaStore1 = new ChicagoStylePizzaStore();
Pizza pizza1 = pizzaStore1.orderPizza("veggie");