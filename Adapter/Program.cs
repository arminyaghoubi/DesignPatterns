using Adapter;
using Adapter.AdapterClasses;

Console.Title = "Adapter";

IPayment payment = new PayPalAdapter(new PayPalPayment());

payment.ProcessPayment(100);

Console.ReadKey();