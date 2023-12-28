namespace Command.Models;

internal class Order
{
    public enum StatusTypes
    {
        Created,
        Approved,
        Canceled
    }

    public int Id { get; set; }
    public string CustomerName { get; set; } = string.Empty;
    public DateTime OrderDateTime { get; set; }
    public List<OrderItem> Items { get; set; } = new List<OrderItem>();
    public decimal TotalAmount { get => Items.Sum(i => i.UnitPrice * i.Quantity); }
    public StatusTypes Status { get; set; }
    public string ShippingAddress { get; set; } = string.Empty;
}