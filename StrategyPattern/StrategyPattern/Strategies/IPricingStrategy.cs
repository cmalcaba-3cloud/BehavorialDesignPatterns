namespace StrategyPattern.Strategies;

public interface IPricingStrategy
{
    decimal Calculate(decimal subtotal);
}
