using FactoryMethod.Messages;

namespace FactoryMethod.Factories;

internal class EmailMessageFactory : MessageFactory
{
    public override IMessage CreateNewMessage()
    {
        return new EmailMessage();
    }
}
