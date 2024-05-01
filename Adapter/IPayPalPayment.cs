namespace Adapter;

internal interface IPayPalPayment
{
    void MakePayment(double amount);
}