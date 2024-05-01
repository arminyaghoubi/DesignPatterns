namespace Adapter.AdapterClasses;

internal class PayPalAdapter : IPayment
{
    private readonly IPayPalPayment _payPalPayment;

    public PayPalAdapter(IPayPalPayment payPalPayment)
    {
        _payPalPayment = payPalPayment;
    }

    public void ProcessPayment(double amount)
    {
        _payPalPayment.MakePayment(amount);
    }
}
