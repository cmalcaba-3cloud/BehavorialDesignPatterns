using StrategyPattern.Contexts;
using StrategyPattern.Strategies;

Console.WriteLine("== Strategy Pattern: Checkout Pricing ==\n");

var cart = new ShoppingCart(100m);

cart.SetStrategy(new RegularPricingStrategy());
Console.WriteLine($"Regular: {cart.CalculateTotal():C}");

cart.SetStrategy(new DiscountPricingStrategy());
Console.WriteLine($"Discount: {cart.CalculateTotal():C}");

cart.SetStrategy(new PremiumPricingStrategy());
Console.WriteLine($"Premium: {cart.CalculateTotal():C}");
