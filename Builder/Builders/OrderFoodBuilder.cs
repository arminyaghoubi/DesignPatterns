using Builder.Entities;

namespace Builder.Builders;

internal class OrderFoodBuilder : IOrderFoodBuilder
{
    private readonly OrderFood _orderFood;

    public OrderFoodBuilder()
    {
        _orderFood = new OrderFood();
    }

    public IOrderFoodBuilder AddAppetizers(List<Food> foods)
    {
        _orderFood.Appetizers = foods;
        return this;
    }

    public IOrderFoodBuilder AddCustomerName(string? customerName)
    {
        _orderFood.CustomerName=customerName;
        return this;
    }

    public IOrderFoodBuilder AddMainDishes(List<Food> foods)
    {
        _orderFood.MainDishes = foods;
        return this;
    }

    public IOrderFoodBuilder AddOrderId(int orderId)
    {
        _orderFood.OrderId = orderId;
        return this;
    }

    public OrderFood Build()
    {
        return _orderFood;
    }
}