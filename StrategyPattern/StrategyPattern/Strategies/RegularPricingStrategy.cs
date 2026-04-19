namespace StrategyPattern.Strategies;

public class RegularPricingStrategy : IPricingStrategy
{
    public decimal Calculate(decimal subtotal) => subtotal;
}
