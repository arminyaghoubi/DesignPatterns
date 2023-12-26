using ChainOfResponsibility.Interfaces;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers.Orders;

internal class AddressHandler : IOrderHandler
{
    private readonly IOrderHandler? _orderHandler;

    public AddressHandler(IOrderHandler? orderHandler = null)
    {
        _orderHandler = orderHandler;
    }

    public void Handle(Order order)
    {
        if (string.IsNullOrEmpty(order.Address))
        {
            throw new Exception("Error: Address cannot be empty or null.");
        }

        _orderHandler?.Handle(order);
    }
}