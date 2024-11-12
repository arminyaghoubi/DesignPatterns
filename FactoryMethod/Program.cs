using FactoryMethod.Factories;

Console.Write("Please enter message type[email, sms]: ");

string? messageType = Console.ReadLine();

Console.Write("Please enter your content: ");

string? content = Console.ReadLine();

Console.Write("Please enter recipinet message: ");

string? to = Console.ReadLine();


MessageFactory messageFactory;

switch (messageType)
{
	case "email":
		messageFactory = new EmailMessageFactory();
		break;
	case "sms":
		messageFactory = new SmsMessageFactory();
		break;
	default:
		throw new ArgumentException("Invalid operation for message type");
}

messageFactory.SendMessage(to, content);

Console.ReadKey();