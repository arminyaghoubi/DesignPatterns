namespace ChainOfResponsibility.Models;

internal class Order
{
    public string CustomerName { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string CustomerPhone { get; set; } = string.Empty;
    public double Amount { get; set; }
}
