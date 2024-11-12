namespace FactoryMethod.Messages;

internal class SmsMessage : IMessage
{
    public void Send(string to, string content)
    {
        Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine($"Sending SMS to {to}\n{content}");

        Console.ResetColor();
    }
}