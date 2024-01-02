using Strategy.Models;
using Strategy.Strategies;

Console.Title = "Online Shop";

BasicTaxStrategy basicTaxStrategy = new();
LuxuryTaxStrategy luxuryTaxStrategy = new();

List<Product> products = [
    new Product(basicTaxStrategy, "IPhone 15", 799),
    new Product(basicTaxStrategy, "IPhone 15 Pro", 999),
    new Product(basicTaxStrategy, "IPhone 15 Pro Max", 1199)
];

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Product List");
Console.ForegroundColor = ConsoleColor.DarkGreen;
int row = 1;
foreach (Product product in products)
{
    Console.WriteLine($"{row++} - {product.Title} => Price: {product.Price}, With Tax: {product.CalculateTotalPrice()}");
}

Console.ReadKey();