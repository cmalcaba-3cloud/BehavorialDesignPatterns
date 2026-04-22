namespace ChainOfResponsibility.Models;

public class DamageRequest
{
    public string AttackerName { get; }
    public DamageType Type { get; }
    public int OriginalAmount { get; }
    public int RemainingAmount { get; set; }

    public DamageRequest(string attackerName, DamageType type, int amount)
    {
        AttackerName = attackerName;
        Type = type;
        OriginalAmount = amount;
        RemainingAmount = amount;
    }
}
