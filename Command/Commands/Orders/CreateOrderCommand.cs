using Command.Models;
using Command.Receivers;

namespace Command.Commands.Orders;

internal class CreateOrderCommand : ICommand
{
    private readonly OrderReceiver _orderReceiver;
    private readonly string _customerName;
    private readonly string _shippingAddress;
    private readonly List<OrderItem> _items;

    public CreateOrderCommand(OrderReceiver orderReceiver, string customerName, string shippingAddress, List<OrderItem> items)
    {
        _orderReceiver = orderReceiver;
        _customerName = customerName;
        _shippingAddress = shippingAddress;
        _items = items;
    }

    public void Execute() => _orderReceiver.Create(_customerName, _shippingAddress, _items);
}