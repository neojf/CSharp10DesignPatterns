namespace FactoryMethod
{
    /// <summary>
    /// Product.
    /// </summary>
    public abstract class Pizza
    {
        protected string Name { get; set; }

        public virtual void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
        }

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }
    }

    /// <summary>
    /// Concrete Product.
    /// </summary>
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            Name = "NY Style Cheese Pizza";
        }

        public override void Bake()
        {
            Console.WriteLine("Bake for 35 minutes at 350");
        }
    }

    /// <summary>
    /// Concrete Product.
    /// </summary>
    public class NYStyleVeggiePizza : Pizza
    {
        public NYStyleVeggiePizza()
        {
            Name = "NY Style Veggie Pizza";
        }
    }

    /// <summary>
    /// Concrete Product.
    /// </summary>
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            Name = "Chicago Style Cheese Pizza";
        }

        public override void Cut()
        {
            Console.WriteLine("Don't need to cut pizza.");
        }
    }

    /// <summary>
    /// Concrete Product.
    /// </summary>
    public class ChicagoStyleVeggiePizza : Pizza
    {
        public ChicagoStyleVeggiePizza()
        {
            Name = "Chicago Style Veggie Pizza";
        }
    }
}