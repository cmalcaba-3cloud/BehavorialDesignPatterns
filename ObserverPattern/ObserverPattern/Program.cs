using ObserverPattern.Observers;
using ObserverPattern.Subjects;

Console.WriteLine("== Observer Pattern: Weather Alerts ==\n");

var weatherStation = new WeatherStation();
weatherStation.Subscribe(new PhoneDisplay("Alice"));
weatherStation.Subscribe(new PhoneDisplay("Bob"));

weatherStation.SetTemperature(28);
weatherStation.SetTemperature(31);
