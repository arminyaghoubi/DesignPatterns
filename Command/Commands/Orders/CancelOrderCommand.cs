using Command.Models;
using Command.Receivers;

namespace Command.Commands.Orders;

internal class CancelOrderCommand : ICommand
{
    private readonly OrderReceiver _orderReceiver;
    private readonly int _orderId;

    public CancelOrderCommand(OrderReceiver orderReceiver, int orderId)
    {
        _orderReceiver = orderReceiver;
        _orderId = orderId;
    }

    public void Execute() => _orderReceiver.Cancel(_orderId);
}