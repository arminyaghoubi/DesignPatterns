using State.Models;

namespace State.States.Orders;

public class Shipped : IOrderState
{
    void IOrderState.ProcessOrder(Order order)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Order shipped. On the way to delivery.");
        order.ChangeState(new Delivered());
    }
}
