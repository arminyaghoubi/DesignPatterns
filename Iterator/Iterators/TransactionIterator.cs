using Iterator.Models;
using System.Collections;

namespace Iterator.Iterators;

internal class TransactionIterator : IIterator<Transaction>
{
    private readonly ArrayList _transactions;
    private int _index = 0;

    public TransactionIterator(ArrayList transactions)
    {
        _transactions = transactions;
    }

    public bool HasNext() => _index < _transactions.Count;

    public Transaction? Next()
    {
        if (HasNext())
        {
            Transaction transaction = (Transaction)_transactions[_index++];
            return transaction;
        }
        else
        {
            return null;
        }
    }
}