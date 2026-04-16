namespace StatePattern.States;

public class YellowState : ITrafficLightState
{
    public void Show() => Console.WriteLine("Yellow: Slow down");

    public ITrafficLightState Next() => new RedState();
}
