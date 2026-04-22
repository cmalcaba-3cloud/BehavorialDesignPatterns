using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers;

/// <summary>
/// Automatically uses a Health Potion when the incoming damage would drop the
/// character's HP to 20% or below. Acts before the damage is applied so the
/// heal can save a life.
/// </summary>
public class AutoPotionHandler : DamageHandler
{
    public override void Handle(DamageRequest request, Character character)
    {
        int projectedHp = character.CurrentHp - request.RemainingAmount;
        int criticalThreshold = (int)(character.MaxHp * 0.20);

        if (projectedHp <= criticalThreshold && character.HealthPotions > 0)
        {
            character.HealthPotions--;
            int healed = Math.Min(character.PotionHealAmount, character.MaxHp - character.CurrentHp);
            character.CurrentHp += healed;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"    [AUTO-POTION]  HP critical! {character.Name} quickly drinks a Health Potion (+{healed} HP). Potions left: {character.HealthPotions}.");
            Console.ResetColor();
        }

        base.Handle(request, character);
    }
}
