using MementoPattern.Mementos;

namespace MementoPattern.Caretakers;

public class History
{
    private readonly Stack<TextMemento> _history = new();

    public void Push(TextMemento memento) => _history.Push(memento);

    public TextMemento Pop() => _history.Pop();
}
