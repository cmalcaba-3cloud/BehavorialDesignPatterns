using CommandPattern.Receivers;

namespace CommandPattern.Commands;

public class ClearTextCommand : ICommand
{
    private readonly TextDocument _document;
    private string _snapshot = string.Empty;

    public ClearTextCommand(TextDocument document)
    {
        _document = document;
    }

    public void Execute()
    {
        _snapshot = _document.Content;
        _document.Clear();
    }

    public void Undo() => _document.Write(_snapshot);
}
