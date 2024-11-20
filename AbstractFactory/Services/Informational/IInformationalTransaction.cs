namespace AbstractFactory.Services.Informational;

internal interface IInformationalTransaction
{
    void Balance(string? sourceCard, string? pin);
    void TransactionSummary(string? sourceCard, string? pin);
}
