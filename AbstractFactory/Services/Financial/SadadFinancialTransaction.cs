namespace AbstractFactory.Services.Financial;

internal class SadadFinancialTransaction : IFinancialTransaction
{
    public void CardToCard(string? sourceCard, string? destinationCard, string? pin, decimal amount)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Transaction Completed.");
        Console.ResetColor();
    }
}
