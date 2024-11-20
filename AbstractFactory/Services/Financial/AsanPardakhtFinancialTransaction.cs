namespace AbstractFactory.Services.Financial;

internal class AsanPardakhtFinancialTransaction : IFinancialTransaction
{
    public void CardToCard(string? sourceCard, string? destinationCard, string? pin, decimal amount)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Transaction Completed.");
        Console.ResetColor();
    }
}
