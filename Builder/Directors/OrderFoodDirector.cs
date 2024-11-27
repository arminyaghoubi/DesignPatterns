using Builder.Builders;
using Builder.Entities;

namespace Builder.Directors;

internal class OrderFoodDirector
{
    private readonly IOrderFoodBuilder _builder;

    public OrderFoodDirector(IOrderFoodBuilder builder)
    {
        _builder = builder;
    }

    public OrderFood Make(int orderId,string? customerName,List<Food> appetizers,List<Food> mainDishes)
    {
        var newOrderFood= _builder.AddOrderId(orderId)
            .AddCustomerName(customerName)
            .AddAppetizers(appetizers)
            .AddMainDishes(mainDishes)
            .Build();

        return newOrderFood;
    }
}
