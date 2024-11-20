using AbstractFactory.Factories;

ITransactionFactory transactionFactory;

Console.Write("Please select a psp[Sadad, Asan Pardakht]: ");

string? psp = Console.ReadLine();

switch (psp)
{
    case "Sadad":
        transactionFactory = new SadadTranscationFactory();
        break;
    case "Asan Pardakht":
        transactionFactory = new AsanPardakhtTranscationFactory();
        break;
    default:
        throw new ArgumentException("Invalid value for psp");
}

do
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("--------------------------------------------");
    Console.ResetColor();

    Console.Write("Please select a transaction[Card to Card, Balance, Transaction Summary]: ");

    string? request = Console.ReadLine();

    Console.Write("Please enter source card: ");
    string? sourceCard = Console.ReadLine();

    Console.Write("Please enter pin: ");
    string? pin = Console.ReadLine();

    if (request == "Card to Card")
    {
        var financialTransaction = transactionFactory.CreateFinancialTransaction();

        Console.Write("Please enter destination card: ");
        string? destinationCard = Console.ReadLine();

        Console.Write("Please enter transaction amount: ");
        decimal amount = decimal.Parse(Console.ReadLine());

        financialTransaction.CardToCard(sourceCard, destinationCard, pin, amount);
    }
    else if (request == "Balance")
    {
        var informationalTransaction = transactionFactory.CreateInfomationalTransaction();
        informationalTransaction.Balance(sourceCard, pin);
    }
    else if (request == "Transaction Summary")
    {
        var informationalTransaction = transactionFactory.CreateInfomationalTransaction();
        informationalTransaction.TransactionSummary(sourceCard, pin);
    }
    else
    {
        throw new ArgumentException("Invalid request.");
    }


    Console.Write("Do you have any other request[Yes, No]:");
} while (Console.ReadLine() == "Yes");