using Strategy.Strategies;

namespace Strategy.Models;

internal class Product
{
    private readonly ITaxStrategy _taxStrategy;

    private string _title;

    public string Title
    {
        get { return _title; }
    }

    private decimal _price;

    public decimal Price
    {
        get { return _price; }
    }

    public Product(ITaxStrategy taxStrategy, string title, decimal price)
    {
        _taxStrategy = taxStrategy;
        _title = title;
        _price = price;
    }

    public decimal CalculateTotalPrice()
    {
        var tax = _taxStrategy.CalculateTax(_price);
        return _price + tax;
    }
}
