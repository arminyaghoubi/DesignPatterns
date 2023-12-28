namespace Iterator.Models;

internal class Transaction
{
    public string Description { get; set; }
    public decimal Amount { get; set; }

    public Transaction(string description, decimal amount)
    {
        Description = description;
        Amount = amount;
    }
}
