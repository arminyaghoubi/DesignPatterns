using Command.Commands;

namespace Command.Invokers;

internal class OrderCommandInvoker
{
    private readonly ICommand _command;

    public OrderCommandInvoker(ICommand command)
    {
        _command = command;
    }

    public void ExecuteCommand()
    {
        _command.Execute();
    }
}
