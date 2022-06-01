namespace FactoryMethod
{
    /// <summary>
    /// Product
    /// </summary>
    public abstract class DiscountService
    {
        public abstract int DiscountPercentage { get; }

        public string Name { get; set; } = "Discount Service";

        public override string ToString()
        {
            return GetType().Name;
        }
    }

    /// <summary>
    /// ConcreteProduct
    /// </summary>
    public class CountryDiscountService: DiscountService
    {
        private readonly string _countryIdentifier;

        public CountryDiscountService(string countryIdentifier)
        {
            Name = "Count Discount Service";
            _countryIdentifier = countryIdentifier;
        }

        public override int DiscountPercentage
        {
            get
            {
                switch (_countryIdentifier)
                {
                    case "CN":
                        return 20;
                    default:
                        return 10;
                }
            }
        }
    }

    /// <summary>
    /// ConcreteProduct
    /// </summary>
    public class CodeDiscountService : DiscountService
    {
        private readonly Guid _code;

        public CodeDiscountService(Guid code)
        {
            Name = "Code Discount Service";
            _code = code;
        }

        public override int DiscountPercentage
        {
            get => 15;
        }
    }
    
    /// <summary>
    /// Creator
    /// </summary>
    public abstract class Shop
    {
        protected DiscountService discountService;
        public abstract DiscountService CreateDiscountService();

        public string Welcome()
        {
            return $"Welcome to the {discountService.Name} Shop!";
        }

        public double CalcutePrice(double rawPrice)
        {
            DiscountService discountService = CreateDiscountService();
            return rawPrice *  (100 - discountService.DiscountPercentage) * 1.0 / 100;
        }
    }

    /// <summary>
    /// ConcreteCreator
    /// </summary>
    public class CountryDiscountShop: Shop
    {
        private readonly string _countryIdentifier;

        public CountryDiscountShop(string countryIdentifier)
        {
            _countryIdentifier = countryIdentifier;
            discountService = CreateDiscountService();
        }

        public override DiscountService CreateDiscountService()
        {
            return new CountryDiscountService(_countryIdentifier);
        }
    }

    /// <summary>
    /// ConcreteCreator
    /// </summary>
    public class CodeDiscountShop : Shop
    {
        private readonly Guid _code;

        public CodeDiscountShop(Guid code)
        {
            _code = code;
            discountService = CreateDiscountService();
        }

        public override DiscountService CreateDiscountService()
        {
            return new CodeDiscountService(_code);
        }
    }
}
