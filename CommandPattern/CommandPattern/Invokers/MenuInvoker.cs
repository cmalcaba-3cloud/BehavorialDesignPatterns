using CommandPattern.Commands;

namespace CommandPattern.Invokers;

public class MenuInvoker
{
    private readonly Stack<ICommand> _history = new();

    public void Execute(ICommand command)
    {
        command.Execute();
        _history.Push(command);
    }

    public void UndoLast()
    {
        if (_history.TryPop(out var command))
        {
            command.Undo();
        }
    }
}
