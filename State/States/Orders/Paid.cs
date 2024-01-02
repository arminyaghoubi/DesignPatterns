using State.Models;

namespace State.States.Orders;

public class Paid : IOrderState
{
    void IOrderState.ProcessOrder(Order order)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Payment received. Preparing for shipping.");
        order.ChangeState(new Shipped());
    }
}
