using Command.Models;
using Command.Receivers;

namespace Command.Commands.Orders;

internal class ApproveOrderCommand : ICommand
{
    private readonly OrderReceiver _orderReceiver;
    private readonly int _orderId;

    public ApproveOrderCommand(OrderReceiver orderReceiver, int orderId)
    {
        _orderReceiver = orderReceiver;
        _orderId = orderId;
    }

    public void Execute() => _orderReceiver.Approve(_orderId);
}