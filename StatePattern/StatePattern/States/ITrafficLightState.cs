namespace StatePattern.States;

public interface ITrafficLightState
{
    void Show();
    ITrafficLightState Next();
}
