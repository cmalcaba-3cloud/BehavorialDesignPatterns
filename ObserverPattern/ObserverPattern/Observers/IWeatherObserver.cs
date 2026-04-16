namespace ObserverPattern.Observers;

public interface IWeatherObserver
{
    void Update(int temperature);
}
