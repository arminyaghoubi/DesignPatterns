namespace AbstractFactory.Services.Informational;

internal class SadadInformationalTransaction : IInformationalTransaction
{
    public void Balance(string? sourceCard, string? pin)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Your account balance is 4,500,000 Rial.");
        Console.ResetColor();
    }

    public void TransactionSummary(string? sourceCard, string? pin)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("1) 2,000,000+ Rial");
        Console.WriteLine("2) 3,000,000+ Rial");
        Console.WriteLine("3) 1,000,000- Rial");
        Console.WriteLine("4) 2,000,000- Rial");
        Console.WriteLine("5) 5,000,000+ Rial");
        Console.ResetColor();
    }
}
