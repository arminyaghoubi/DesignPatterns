using ChainOfResponsibility.Interfaces;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers.Orders;

internal class CustomerPhoneHandler : IOrderHandler
{
    private readonly IOrderHandler? _orderHandler;

    public CustomerPhoneHandler(IOrderHandler? orderHandler = null)
    {
        _orderHandler = orderHandler;
    }

    public void Handle(Order order)
    {
        if (string.IsNullOrEmpty(order.CustomerPhone))
        {
            throw new Exception("Error: Customer phone cannot be empty or null.");
        }

        _orderHandler?.Handle(order);
    }
}