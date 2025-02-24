using ChainOfResponsibility.Handlers.Base;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers;

internal class DailyTransactionHandler : BaseHandler
{
    public override void Handle(SaleTransactionRequest request)
    {
        decimal totalDailyTransaction = 20_000_000;

        if (totalDailyTransaction+request.Amount>30_000_000)
        {
            throw new Exception("Invalid Daily Transaction.");
        }

        base.Handle(request);
    }
}
