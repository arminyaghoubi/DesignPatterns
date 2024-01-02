using State.Models;

namespace State.States.Orders;

internal interface IOrderState
{
    void ProcessOrder(Order order);
}