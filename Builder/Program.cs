using Builder.Builders;
using Builder.Directors;
using Builder.Entities;

IOrderFoodBuilder builder = new OrderFoodBuilder();

OrderFoodDirector orderFoodDirector = new(builder);

List<Food> appetizerList = new List<Food>()
{
    new Food(){ Id=1,Title="Salad",Price=2},
    new Food(){ Id=2,Title="Fries",Price=5},
};

List<Food> mainDisheList = new List<Food>
{
    new Food(){ Id=3,Title="Pizza",Price=10},
    new Food(){ Id=4,Title="Pasta",Price=7},
    new Food(){ Id=5,Title="Lasagna",Price=7},
};

int orderId = 5;
string customerName = "Armin Yaghoubi";

var newOrderFood= orderFoodDirector.Make(orderId, customerName, appetizerList, mainDisheList);

Console.WriteLine($"Total Price is {newOrderFood.CalculateTotalPrice()}$");