using Builder.Entities;

namespace Builder.Builders;

internal interface IOrderFoodBuilder
{
    IOrderFoodBuilder AddOrderId(int orderId);
    IOrderFoodBuilder AddCustomerName(string? customerName);
    IOrderFoodBuilder AddAppetizers(List<Food> foods);
    IOrderFoodBuilder AddMainDishes(List<Food> foods);

    OrderFood Build();
}
