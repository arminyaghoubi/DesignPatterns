using State.Models;

namespace State.States.Orders;

public class NewOrder : IOrderState
{
    void IOrderState.ProcessOrder(Order order)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{order.CustomerName}'s Order placed. Waiting for payment.");
        order.ChangeState(new Paid());
    }
}
