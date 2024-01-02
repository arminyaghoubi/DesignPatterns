namespace Strategy.Strategies;

internal interface ITaxStrategy
{
    decimal CalculateTax(decimal price);
}