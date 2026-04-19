using ObserverPattern.Observers;

namespace ObserverPattern.Subjects;

public class WeatherStation
{
    private readonly List<IWeatherObserver> _observers = new();

    public void Subscribe(IWeatherObserver observer) => _observers.Add(observer);

    public void SetTemperature(int temperature)
    {
        foreach (var observer in _observers)
        {
            observer.Update(temperature);
        }
    }
}
