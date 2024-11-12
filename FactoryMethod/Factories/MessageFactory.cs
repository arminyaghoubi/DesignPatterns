using FactoryMethod.Messages;

namespace FactoryMethod.Factories;

internal abstract class MessageFactory
{
    public abstract IMessage CreateNewMessage();

    public void SendMessage(string to,string content)
    {
        var message = CreateNewMessage();

        message.Send(to, content);

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Message Sent.");
        Console.ResetColor();
    }
}
