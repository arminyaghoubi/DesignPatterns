using State.States.Orders;

namespace State.Models;

internal class Order
{
    public string CustomerName { get; private set; }
    public string Address { get; private set; }
    public IOrderState OrderState { get; private set; }

    public Order(string customerName,string address)
    {
        CustomerName = customerName;
        Address = address;
        OrderState = new NewOrder();
    }

    public void ChangeState(IOrderState orderState)
    {
        OrderState = orderState;
    }

    public void ProcessOrder()
    {
        OrderState.ProcessOrder(this);
    }
}
