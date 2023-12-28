using Iterator.Iterators;
using Iterator.Models;
using System.Collections;

ArrayList transactions = new ArrayList();
transactions.Add(new Transaction("Sale", 1000));
transactions.Add(new Transaction("Purchase", -500));
transactions.Add(new Transaction("Salary", 3000));

var iterator = new TransactionIterator(transactions);

Console.WriteLine("Transactions:");
while (iterator.HasNext())
{
    Transaction transaction = iterator.Next();
    if (transaction.Amount >= 0)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
    }
    Console.WriteLine($"- {transaction.Description}: {transaction.Amount}");
}

Console.ForegroundColor = ConsoleColor.Gray;

decimal totalAmount = 0;
iterator = new TransactionIterator(transactions);
while (iterator.HasNext())
{
    Transaction transaction = iterator.Next();
    totalAmount += transaction.Amount;
}
Console.WriteLine($"Total Amount: {totalAmount}");

Console.ReadKey();