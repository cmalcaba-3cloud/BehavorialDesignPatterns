using ChainOfResponsibility.Handlers;
using ChainOfResponsibility.Models;

// ─────────────────────────────────────────────────────────────────────────────
//  RPG Combat — Chain of Responsibility Demo
//
//  Each attack from an enemy travels through a chain of defensive handlers:
//
//    DodgeHandler        → rolls a dodge chance (Physical only)
//        ↓ (on miss)
//    ArmorHandler        → absorbs flat Physical damage
//        ↓ (if damage remains)
//    MagicShieldHandler  → absorbs Magical damage from a shield pool
//        ↓ (if damage remains)
//    AutoPotionHandler   → auto-drinks a potion if HP would go critical
//        ↓
//    CharacterHandler    → applies remaining damage to HP  (end of chain)
//
//  True damage bypasses both Armor and Magic Shield and cannot be dodged.
// ─────────────────────────────────────────────────────────────────────────────

PrintBanner();

// ── Hero setup ────────────────────────────────────────────────────────────────
var hero = new Character(
    name:             "Sir Aldric",
    maxHp:            100,
    armor:            15,           // flat reduction per physical hit
    magicShield:      30,           // pool that absorbs magical hits
    dodgeChance:      0.35,         // 35 % chance to dodge physical attacks
    healthPotions:    2,
    potionHealAmount: 40);

Console.WriteLine("  Hero : " + hero.Name);
Console.WriteLine($"  HP   : {hero.MaxHp}  |  Armor: {hero.Armor} pts  |  Magic Shield: {hero.MagicShield} pts");
Console.WriteLine($"  Dodge: {hero.DodgeChance * 100:0}%  |  Health Potions: {hero.HealthPotions} (heals {hero.PotionHealAmount} HP each)");
Console.WriteLine();

// ── Build the chain ───────────────────────────────────────────────────────────
var random         = new Random(7);   // seeded so the run is reproducible
var dodgeHandler   = new DodgeHandler(random);
var armorHandler   = new ArmorHandler();
var shieldHandler  = new MagicShieldHandler();
var potionHandler  = new AutoPotionHandler();
var characterHandler = new CharacterHandler();

dodgeHandler
    .SetNext(armorHandler)
    .SetNext(shieldHandler)
    .SetNext(potionHandler)
    .SetNext(characterHandler);

// ── Enemy attack roster ───────────────────────────────────────────────────────
var attacks = new List<DamageRequest>
{
    new("Goblin Scout",      DamageType.Physical,  12),
    new("Dark Wizard",       DamageType.Magical,   20),
    new("Orc Brute",         DamageType.Physical,  30),
    new("Necromancer",       DamageType.Magical,   28),
    new("Stone Golem",       DamageType.Physical,   8),
    new("Chaos Demon",       DamageType.True,       25),  // bypasses all defenses
    new("Dragon",            DamageType.Physical,  45),
    new("Shadow Assassin",   DamageType.Physical,  18),
    new("Ancient Lich",      DamageType.Magical,   55),
    new("Void Wraith",       DamageType.True,       40),  // bypasses all defenses
};

// ── Combat loop ───────────────────────────────────────────────────────────────
int round = 1;
foreach (var attack in attacks)
{
    if (!hero.IsAlive) break;

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"Round {round++}  |  {attack.AttackerName} attacks  [{attack.Type} — {attack.OriginalAmount} pts]");
    Console.ResetColor();
    Console.WriteLine(new string('-', 62));

    dodgeHandler.Handle(attack, hero);

    Console.WriteLine();
    hero.PrintStatus();
    Console.WriteLine();
}

// ── Result ────────────────────────────────────────────────────────────────────
Console.WriteLine(new string('=', 62));
if (hero.IsAlive)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"  {hero.Name} survived with {hero.CurrentHp}/{hero.MaxHp} HP remaining. Victory!");
}
else
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"  {hero.Name} has fallen. Game Over.");
}
Console.ResetColor();
Console.WriteLine(new string('=', 62));

// ── Helpers ───────────────────────────────────────────────────────────────────
static void PrintBanner()
{
    Console.WriteLine(new string('=', 62));
    Console.WriteLine("   RPG COMBAT  —  Chain of Responsibility Pattern Demo");
    Console.WriteLine(new string('=', 62));
    Console.WriteLine();
    Console.WriteLine("  Chain:  Dodge -> Armor -> Magic Shield -> Auto-Potion -> Hit");
    Console.WriteLine();
    Console.WriteLine("  Damage types:");
    Console.WriteLine("    Physical  — dodgeable; reduced by Armor");
    Console.WriteLine("    Magical   — not dodgeable; absorbed by Magic Shield");
    Console.WriteLine("    True      — bypasses all defenses; cannot be dodged");
    Console.WriteLine();
}
