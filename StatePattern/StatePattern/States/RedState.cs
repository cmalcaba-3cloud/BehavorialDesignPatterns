namespace StatePattern.States;

public class RedState : ITrafficLightState
{
    public void Show() => Console.WriteLine("Red: Stop");

    public ITrafficLightState Next() => new GreenState();
}
