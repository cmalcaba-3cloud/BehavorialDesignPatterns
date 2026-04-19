using StrategyPattern.Strategies;

namespace StrategyPattern.Contexts;

public class ShoppingCart
{
    private IPricingStrategy _strategy = new RegularPricingStrategy();

    public ShoppingCart(decimal subtotal)
    {
        Subtotal = subtotal;
    }

    public decimal Subtotal { get; }

    public void SetStrategy(IPricingStrategy strategy) => _strategy = strategy;

    public decimal CalculateTotal() => _strategy.Calculate(Subtotal);
}
