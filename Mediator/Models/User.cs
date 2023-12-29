using Mediator.Mediators;

namespace Mediator.Models;

internal class User
{
    private readonly IChatMediator _mediator;
    private readonly string _username;

    public string UserName { get => _username; }

    public User(IChatMediator mediator, string username)
    {
        _mediator = mediator;
        _username = username;
    }

    public void ReceiveMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"{_username} received message: {message}");
    }

    public void SendMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{_username} sent message.");
        _mediator.SendChat(message, this);
    }
}
