using ChainOfResponsibility.Handlers.Base;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers;

internal class AmountHandler : BaseHandler
{
    public override void Handle(SaleTransactionRequest request)
    {
        if (request.Amount<10000)
        {
            throw new Exception("Invalid Amount.");
        }

        base.Handle(request);
    }
}
