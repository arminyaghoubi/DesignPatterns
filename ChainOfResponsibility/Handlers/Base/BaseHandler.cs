using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers.Base;

internal abstract class BaseHandler : IHandler
{
    protected IHandler? _nextHandler;

    public void SetNextHandler(IHandler handler)
    {
        _nextHandler = handler;
    }

    public virtual void Handle(SaleTransactionRequest request)
    {
        if(_nextHandler!=null)
            _nextHandler.Handle(request);
    }
}