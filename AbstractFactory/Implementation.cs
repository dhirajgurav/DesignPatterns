﻿namespace AbstractFactory
{
    /// <summary>
    /// Abstract Factory
    /// </summary>
    public interface IShoppingCartPurchaseFactory
    {
        IDiscountService CreateDiscountService();

        IShippingCostsService CreateShippingCostsService();
    }
    
    /// <summary>
    /// Abstract Product
    /// </summary>
    public interface IDiscountService
    {
        int DiscountPercentage { get; }        
    }

    //Concreate Product
    public class BelgiumDiscountService : IDiscountService
    {
        public int DiscountPercentage => 20;
    }

    /// <summary>
    /// Concrete Product
    /// </summary>
    public class FranceDiscountService : IDiscountService
    {
        public int DiscountPercentage => 10;
    }

    /// <summary>
    /// Abstract product
    /// </summary>
    public interface IShippingCostsService
    {
        decimal ShippingCosts { get; }
    }

    /// <summary>
    /// Concrete Product
    /// </summary>
    public class BelgiumShippingCostsService : IShippingCostsService
    {
        public decimal ShippingCosts => 20;
    }

    /// <summary>
    /// Concrete Product
    /// </summary>
    public class FranceShippingCostsService : IShippingCostsService
    {
        public decimal ShippingCosts => 25;
    }

    /// <summary>
    /// Concrete Factory
    /// </summary>
    public class BelgiumShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory
    {
        public IDiscountService CreateDiscountService()
        {
            return new BelgiumDiscountService();
        }

        public IShippingCostsService CreateShippingCostsService()
        {
            return new BelgiumShippingCostsService();
        }
    }

    /// <summary>
    /// Concrete Facotory
    /// </summary>
    public class FranceShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory
    {
        public IDiscountService CreateDiscountService()
        {
            return new FranceDiscountService();
        }

        public IShippingCostsService CreateShippingCostsService()
        {
            return new FranceShippingCostsService();
        }
    }

    /// <summary>
    /// Client Class
    /// </summary>
    public class ShoppingCart
    {
        private readonly IDiscountService _discountService;
        private readonly IShippingCostsService _shippingCostsService;
        private int _orderCosts;

        public ShoppingCart(IShoppingCartPurchaseFactory factory)
        {
            _discountService = factory.CreateDiscountService();
            _shippingCostsService = factory.CreateShippingCostsService();
            _orderCosts = 200;
        }

        public void CalculateCosts()
        {
            Console.WriteLine(
                $"Total Costs = {_orderCosts - (_orderCosts / 100 * _discountService.DiscountPercentage) + _shippingCostsService.ShippingCosts}");
        }
    }
}
