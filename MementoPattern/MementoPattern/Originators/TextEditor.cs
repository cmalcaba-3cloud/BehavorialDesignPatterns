using MementoPattern.Mementos;

namespace MementoPattern.Originators;

public class TextEditor
{
    public string Content { get; private set; } = string.Empty;

    public void Write(string text) => Content += text;

    public TextMemento CreateSnapshot() => new(Content);

    public void Restore(TextMemento memento) => Content = memento.Content;
}
