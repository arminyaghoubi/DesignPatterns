using ChainOfResponsibility.Interfaces;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers.Orders;

internal class CustomerNameHandler : IOrderHandler
{
    private readonly IOrderHandler? _orderHandler;

    public CustomerNameHandler(IOrderHandler? orderHandler = null)
    {
        _orderHandler = orderHandler;
    }

    public void Handle(Order order)
    {
        if (string.IsNullOrEmpty(order.CustomerName))
        {
            throw new Exception("Error: Customer name cannot be empty or null.");
        }

        _orderHandler?.Handle(order);
    }
}