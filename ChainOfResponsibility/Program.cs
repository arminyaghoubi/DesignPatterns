using ChainOfResponsibility.Handlers.Orders;
using ChainOfResponsibility.Interfaces;
using ChainOfResponsibility.Models;

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("Chain of Responsibility");

Order order = new()
{
    Amount = 10,
    CustomerName = "Armin Yaghoubi",
    CustomerPhone = "09912509526",
    Address = "Iran, Tehran"
};

IOrderHandler addressHandler = new AddressHandler();
IOrderHandler customerPhoneHandler = new CustomerPhoneHandler(addressHandler);
IOrderHandler customerNameHandler = new CustomerNameHandler(customerPhoneHandler);
IOrderHandler amountHandler = new AmountHandler(customerNameHandler);

try
{
    amountHandler.Handle(order);

    Console.ForegroundColor= ConsoleColor.White;
    Console.WriteLine("The order is ok!");
}
catch (Exception ex)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(ex.Message);
}


Console.ReadKey();