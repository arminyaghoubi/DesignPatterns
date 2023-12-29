using Mediator.Models;

namespace Mediator.Mediators;

internal interface IChatMediator
{
    void SendChat(string message,User sender);
    void AddUser(User user);
}
