using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers;

/// <summary>
/// Absorbs incoming Magical damage using the character's magic shield pool.
/// Physical and True damage pass through untouched. The shield does not regenerate.
/// </summary>
public class MagicShieldHandler : DamageHandler
{
    public override void Handle(DamageRequest request, Character character)
    {
        if (request.Type == DamageType.Magical && character.MagicShield > 0)
        {
            int absorbed = Math.Min(character.MagicShield, request.RemainingAmount);
            character.MagicShield -= absorbed;
            request.RemainingAmount -= absorbed;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"    [MAGIC SHIELD]  Absorbed {absorbed} magical damage. Shield remaining: {character.MagicShield} pts. Damage remaining: {request.RemainingAmount} pts.");
            Console.ResetColor();

            if (request.RemainingAmount == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"    [MAGIC SHIELD]  Spell fully absorbed by the magic shield!");
                Console.ResetColor();
                return; // Nothing left to pass on.
            }
        }

        base.Handle(request, character);
    }
}
