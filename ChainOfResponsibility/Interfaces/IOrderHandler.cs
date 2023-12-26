using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Interfaces;

internal interface IOrderHandler
{
    void Handle(Order order);
}
