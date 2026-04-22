namespace ChainOfResponsibility.Models;

public class Character
{
    public string Name { get; }
    public int MaxHp { get; }
    public int CurrentHp { get; set; }
    public int Armor { get; }
    public int MagicShield { get; set; }
    public double DodgeChance { get; }
    public int HealthPotions { get; set; }
    public int PotionHealAmount { get; }

    public bool IsAlive => CurrentHp > 0;

    public Character(
        string name,
        int maxHp,
        int armor,
        int magicShield,
        double dodgeChance,
        int healthPotions,
        int potionHealAmount)
    {
        Name = name;
        MaxHp = maxHp;
        CurrentHp = maxHp;
        Armor = armor;
        MagicShield = magicShield;
        DodgeChance = dodgeChance;
        HealthPotions = healthPotions;
        PotionHealAmount = potionHealAmount;
    }

    public void PrintStatus()
    {
        const int barLength = 30;
        int filled = (int)Math.Round((double)CurrentHp / MaxHp * barLength);
        string healthBar = new string('#', filled) + new string('-', barLength - filled);
        Console.WriteLine($"  HP           : [{healthBar}] {CurrentHp}/{MaxHp}");
        Console.WriteLine($"  Armor        : {Armor} pts");
        Console.WriteLine($"  Magic Shield : {MagicShield} pts");
        Console.WriteLine($"  Health Pots  : {HealthPotions}");
    }
}
