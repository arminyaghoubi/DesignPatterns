namespace Strategy.Strategies;

internal class LuxuryTaxStrategy : ITaxStrategy
{
    public decimal CalculateTax(decimal price)
    {
        return price * 0.2M;
    }
}