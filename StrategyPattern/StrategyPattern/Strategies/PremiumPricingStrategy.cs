namespace StrategyPattern.Strategies;

public class PremiumPricingStrategy : IPricingStrategy
{
    public decimal Calculate(decimal subtotal) => subtotal * 0.8m;
}
