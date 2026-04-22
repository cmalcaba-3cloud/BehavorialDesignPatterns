using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers;

/// <summary>
/// Reduces incoming Physical damage by the character's flat armor value.
/// Magical and True damage pass through untouched.
/// </summary>
public class ArmorHandler : DamageHandler
{
    public override void Handle(DamageRequest request, Character character)
    {
        if (request.Type == DamageType.Physical && character.Armor > 0)
        {
            int absorbed = Math.Min(character.Armor, request.RemainingAmount);
            request.RemainingAmount -= absorbed;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"    [ARMOR]        Deflected {absorbed} physical damage. Remaining: {request.RemainingAmount} pts.");
            Console.ResetColor();

            if (request.RemainingAmount == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"    [ARMOR]        Attack fully absorbed by armor!");
                Console.ResetColor();
                return; // Nothing left to pass on.
            }
        }

        base.Handle(request, character);
    }
}
