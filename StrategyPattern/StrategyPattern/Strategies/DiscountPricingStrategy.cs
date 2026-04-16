namespace StrategyPattern.Strategies;

public class DiscountPricingStrategy : IPricingStrategy
{
    public decimal Calculate(decimal subtotal) => subtotal * 0.9m;
}
