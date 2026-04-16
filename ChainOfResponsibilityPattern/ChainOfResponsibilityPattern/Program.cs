using ChainOfResponsibilityPattern.Handlers;

Console.WriteLine("== Chain of Responsibility Pattern: Support Desk ==\n");

var level1 = new Level1SupportHandler();
var level2 = new Level2SupportHandler();
var manager = new ManagerSupportHandler();

level1.SetNext(level2).SetNext(manager);

foreach (var request in new[]
{
    new SupportRequest("Password reset", 1),
    new SupportRequest("VPN issue", 2),
    new SupportRequest("Production outage", 3)
})
{
    Console.WriteLine(level1.Handle(request));
}
