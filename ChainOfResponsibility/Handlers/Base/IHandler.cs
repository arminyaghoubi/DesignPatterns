using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers.Base;

internal interface IHandler
{
    void SetNextHandler(IHandler handler);
    void Handle(SaleTransactionRequest request);
}
