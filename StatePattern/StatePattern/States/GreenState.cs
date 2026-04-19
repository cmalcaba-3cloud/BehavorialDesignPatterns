namespace StatePattern.States;

public class GreenState : ITrafficLightState
{
    public void Show() => Console.WriteLine("Green: Go");

    public ITrafficLightState Next() => new YellowState();
}
