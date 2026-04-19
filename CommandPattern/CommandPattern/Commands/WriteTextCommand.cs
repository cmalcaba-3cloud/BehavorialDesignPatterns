using CommandPattern.Receivers;

namespace CommandPattern.Commands;

public class WriteTextCommand : ICommand
{
    private readonly TextDocument _document;
    private readonly string _text;

    public WriteTextCommand(TextDocument document, string text)
    {
        _document = document;
        _text = text;
    }

    public void Execute() => _document.Write(_text);

    public void Undo() => _document.RemoveLast(_text.Length);
}
