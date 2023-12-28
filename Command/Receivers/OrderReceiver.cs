using Command.Models;

namespace Command.Receivers;

// The Receiver classes contain some important business logic. They know how
// to perform all kinds of operations, associated with carrying out a
// request. In fact, any class may serve as a Receiver.
internal class OrderReceiver
{
    private readonly List<Order> _orders;

    public OrderReceiver()
    {
        _orders = new List<Order>();
    }

    public void Create(string customerName, string shippingAddress, List<OrderItem> items)
    {
        Order order = new Order
        {
            Id = _orders.Count + 1,
            CustomerName = customerName,
            OrderDateTime = DateTime.Now,
            ShippingAddress = shippingAddress,
            Items = items,
            Status = Order.StatusTypes.Created,
        };

        _orders.Add(order);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Order {order.Id} created successfully for {order.CustomerName}.");
    }

    public void Approve(int id)
    {
        Order? order = _orders.Find(o => o.Id == id);

        if (order is not null)
        {
            order.Status = Order.StatusTypes.Approved;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Order {order.Id} has been approved.");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Order {id} not found.");
        }
    }

    public void Cancel(int id)
    {
        Order? order = _orders.Find(o => o.Id == id);

        if (order is not null)
        {
            order.Status = Order.StatusTypes.Canceled;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Order {order.Id} has been canceled.");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Order {id} not found.");
        }
    }
}
