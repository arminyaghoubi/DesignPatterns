using ChainOfResponsibility.Handlers;
using ChainOfResponsibility.Models;

AmountHandler amountHandler = new();
DailyTransactionHandler dailyTransactionHandler = new();
BalanceHandler balanceHandler = new();

amountHandler.SetNextHandler(dailyTransactionHandler);
dailyTransactionHandler.SetNextHandler(balanceHandler);

SaleTransactionRequest request = new SaleTransactionRequest
{
    PrimaryAccountNumber = "6221061012345678",
    Password = "0000",
    Amount = 50_000_000
};

try
{
    amountHandler.Handle(request);
}
catch (Exception ex)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(ex.Message);
}