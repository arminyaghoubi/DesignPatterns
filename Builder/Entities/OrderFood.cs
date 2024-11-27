namespace Builder.Entities;

internal class OrderFood
{
    public int OrderId { get; set; }
    public string? CustomerName { get; set; }

    public List<Food> Appetizers { get; set; }
    public List<Food> MainDishes { get; set; }

    public decimal CalculateTotalPrice()
    {
        decimal totalPrice = 0;

        foreach (var item in Appetizers)
        {
            totalPrice+= item.Price;
        }

        foreach (var item in MainDishes)
        {
            totalPrice+= item.Price;
        }

        return totalPrice;
    }
}