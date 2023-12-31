using Observer.Interfaces;
using System.Xml.Linq;

namespace Observer.Subscribers;

internal class Observer : IObserver
{
    private string _name;

    public Observer(string name)
    {
        _name = name;
    }

    public void Update(string message)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"{_name} received message: {message}");
    }
}
