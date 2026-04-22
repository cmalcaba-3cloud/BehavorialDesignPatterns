using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers;

/// <summary>
/// First line of defense. Only Physical attacks can be dodged.
/// If the roll succeeds the chain is stopped entirely — the attack misses.
/// </summary>
public class DodgeHandler : DamageHandler
{
    private readonly Random _random;

    public DodgeHandler(Random random)
    {
        _random = random;
    }

    public override void Handle(DamageRequest request, Character character)
    {
        if (request.Type == DamageType.Physical && _random.NextDouble() < character.DodgeChance)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"    [DODGE]        {character.Name} sidesteps the blow from {request.AttackerName} — no damage taken!");
            Console.ResetColor();
            return; // Attack missed; stop the chain.
        }

        base.Handle(request, character);
    }
}
