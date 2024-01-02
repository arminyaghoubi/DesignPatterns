namespace Strategy.Strategies;

internal class BasicTaxStrategy : ITaxStrategy
{
    public decimal CalculateTax(decimal price)
    {
        return price * 0.1M;
    }
}
