using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers;

/// <summary>
/// Terminal handler — applies whatever damage remains after all other handlers
/// have had their say directly to the character's HP. End of the chain.
/// </summary>
public class CharacterHandler : DamageHandler
{
    public override void Handle(DamageRequest request, Character character)
    {
        if (request.RemainingAmount > 0)
        {
            character.CurrentHp = Math.Max(0, character.CurrentHp - request.RemainingAmount);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"    [HIT]          {character.Name} takes {request.RemainingAmount} damage!");
            Console.ResetColor();

            if (!character.IsAlive)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"    [FALLEN]       {character.Name} collapses...");
                Console.ResetColor();
            }
        }

        // End of chain — no call to base.Handle().
    }
}
