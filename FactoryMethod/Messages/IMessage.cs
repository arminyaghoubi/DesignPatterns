namespace FactoryMethod.Messages;

internal interface IMessage
{
    void Send(string to, string content);
}