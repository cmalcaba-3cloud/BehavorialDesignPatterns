namespace ObserverPattern.Observers;

public class PhoneDisplay : IWeatherObserver
{
    private readonly string _owner;

    public PhoneDisplay(string owner)
    {
        _owner = owner;
    }

    public void Update(int temperature)
    {
        Console.WriteLine($"{_owner} sees temperature: {temperature}°C");
    }
}
