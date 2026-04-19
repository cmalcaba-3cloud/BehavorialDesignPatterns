using StatePattern.Contexts;
using StatePattern.States;

Console.WriteLine("== State Pattern: Traffic Light ==\n");

var trafficLight = new TrafficLight(new RedState());

for (var i = 0; i < 4; i++)
{
    trafficLight.Show();
    trafficLight.Next();
}
