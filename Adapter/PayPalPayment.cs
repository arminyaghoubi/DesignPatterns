namespace Adapter;

internal class PayPalPayment : IPayPalPayment
{
    public void MakePayment(double amount)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Paying {amount} using PayPal.");
    }
}