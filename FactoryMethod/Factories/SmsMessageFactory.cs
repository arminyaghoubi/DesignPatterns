using FactoryMethod.Messages;

namespace FactoryMethod.Factories;

internal class SmsMessageFactory : MessageFactory
{
    public override IMessage CreateNewMessage()
    {
        return new SmsMessage();
    }
}