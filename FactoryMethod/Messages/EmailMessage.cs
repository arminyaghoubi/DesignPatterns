namespace FactoryMethod.Messages;

internal class EmailMessage : IMessage
{
    public void Send(string to, string content)
    {
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine($"Sending Email to {to}\n{content}");

        Console.ResetColor();
    }
}
