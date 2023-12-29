using Mediator.Models;

namespace Mediator.Mediators;

internal class ChatRoomMediator : IChatMediator
{
    private readonly List<User> _users = new List<User>();

    public void SendChat(string message, User userSender)
    {
        var users = _users.Where(u => u.UserName != userSender.UserName);
        foreach (var user in users)
        {
            user.ReceiveMessage(message);
        }
    }

    public void AddUser(User user) => _users.Add(user);
}