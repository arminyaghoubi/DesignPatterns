using ChainOfResponsibility.Handlers.Base;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers;

internal class BalanceHandler : BaseHandler
{
    public override void Handle(SaleTransactionRequest request)
    {
        decimal balance = 25_000_000;

        if (balance<request.Amount)
        {
            throw new Exception("Balance Exception.");
        }

        base.Handle(request);
    }
}