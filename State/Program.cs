using State.Models;

Console.Title = "Online Order";

Order order = new Order("Armin Yaghoubi", "Iran, Tehran");

order.ProcessOrder();
order.ProcessOrder();
order.ProcessOrder();
order.ProcessOrder();

Console.ReadKey();