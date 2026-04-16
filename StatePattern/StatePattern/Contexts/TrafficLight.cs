using StatePattern.States;

namespace StatePattern.Contexts;

public class TrafficLight
{
    private ITrafficLightState _state;

    public TrafficLight(ITrafficLightState state)
    {
        _state = state;
    }

    public void Show() => _state.Show();

    public void Next() => _state = _state.Next();
}
