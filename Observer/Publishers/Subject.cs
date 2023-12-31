using Observer.Interfaces;

internal class Subject
{
    private List<IObserver> _observers = new List<IObserver>();

    private string _message;

    public string Message
    {
        get { return _message; }
        set
        {
            _message = value;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Publisher message: ({_message})");
        }
    }

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_message);
        }
    }
}
