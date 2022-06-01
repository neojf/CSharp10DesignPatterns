namespace FactoryMethod
{
    /// <summary>
    /// Creator.
    /// </summary>
    public abstract class PizzaStore
    {
        public abstract Pizza CreatePizza(string type);

        public Pizza orderPizza(string type)
        {
            Pizza pizza = this.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
    
    /// <summary>
    /// Concrete Creator.
    /// </summary>
    public class NYStylePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza;
            if (type.Equals("cheese", StringComparison.InvariantCultureIgnoreCase))
            {
                pizza = new NYStyleCheesePizza();
            }
            else if (type.Equals("veggie", StringComparison.InvariantCultureIgnoreCase))
            {
                pizza = new NYStyleVeggiePizza();
            }
            else
            {
                throw new NotImplementedException("The type is not implemented.");
            }

            return pizza;
        }
    }

    /// <summary>
    /// Concrete Creator.
    /// </summary>
    public class ChicagoStylePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza;
            if (type.Equals("cheese", StringComparison.InvariantCultureIgnoreCase))
            {
                pizza = new ChicagoStyleCheesePizza();
            }
            else if (type.Equals("veggie", StringComparison.InvariantCultureIgnoreCase))
            {
                pizza = new ChicagoStyleVeggiePizza();
            }
            else
            {
                throw new NotImplementedException("The type is not implemented.");
            }

            return pizza;
        }
    }
}
