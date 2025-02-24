namespace ChainOfResponsibility.Models;

internal class SaleTransactionRequest
{
    public string PrimaryAccountNumber { get; set; } = null!;
    public string Password { get; set; } = null!;
    public decimal Amount { get; set; }
}
