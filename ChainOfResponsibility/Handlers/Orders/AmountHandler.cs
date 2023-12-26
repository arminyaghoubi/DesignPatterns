using ChainOfResponsibility.Interfaces;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers.Orders;

internal class AmountHandler : IOrderHandler
{
    private readonly IOrderHandler? _orderHandler;

    public AmountHandler(IOrderHandler? orderHandler = null)
    {
        _orderHandler = orderHandler;
    }

    public void Handle(Order order)
    {
        if (order.Amount < 1)
        {
            throw new Exception("Error: The order amount cannot be less than or equal to zero.");
        }

        _orderHandler?.Handle(order);
    }
}
