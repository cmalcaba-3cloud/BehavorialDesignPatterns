namespace ChainOfResponsibility.Models;

public enum DamageType
{
    /// <summary>Reduced by Armor; can be dodged.</summary>
    Physical,

    /// <summary>Absorbed by Magic Shield; cannot be dodged.</summary>
    Magical,

    /// <summary>Bypasses all defenses; cannot be dodged or blocked.</summary>
    True
}
