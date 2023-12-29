using Mediator.Mediators;
using Mediator.Models;

Console.Title = "ChatRoom";

IChatMediator mediator = new ChatRoomMediator();

var user1 = new User(mediator, "ArminYaghoubi1");
var user2 = new User(mediator, "Shayan");
var user3 = new User(mediator, "Nikan");

mediator.AddUser(user1);
mediator.AddUser(user2);
mediator.AddUser(user3);

user1.SendMessage("Hi every body.");

Console.ReadKey();
Console.ReadKey();
Console.ReadKey();