namespace AbstractFactory.Services.Financial;

internal interface IFinancialTransaction
{
    void CardToCard(string? sourceCard, string? destinationCard, string? pin, decimal amount);
}
