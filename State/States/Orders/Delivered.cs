using State.Models;

namespace State.States.Orders;

public class Delivered : IOrderState
{
    void IOrderState.ProcessOrder(Order order)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"Order delivered successfully.");
        order.ChangeState(new Shipped());
    }
}