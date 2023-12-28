using Command.Commands.Orders;
using Command.Invokers;
using Command.Models;
using Command.Receivers;

Console.Title = "Store";
Console.WriteLine("Hello, World!");

OrderCommandInvoker commandInvoker;
OrderReceiver receiver = new OrderReceiver();

// Create a order
List<OrderItem> orderItems = new List<OrderItem>
{
    new OrderItem(){ProductId=1,ProductName="Samsung Monitor Deals",Quantity=1,UnitPrice=500},
    new OrderItem(){ProductId=2,ProductName="C3 Gaming Chair",Quantity=1,UnitPrice=250},
};
commandInvoker = new OrderCommandInvoker(new CreateOrderCommand(receiver, "Armin Yaghoubi", "Iran, Tehran", orderItems));
commandInvoker.ExecuteCommand();

// Approve
commandInvoker = new OrderCommandInvoker(new ApproveOrderCommand(receiver, 1));
commandInvoker.ExecuteCommand();

// Cancel
commandInvoker = new OrderCommandInvoker(new CancelOrderCommand(receiver, 1));
commandInvoker.ExecuteCommand();

Console.ReadKey();