namespace CommandPattern.Receivers;

public class TextDocument
{
    public string Content { get; private set; } = string.Empty;

    public void Write(string text) => Content += text;

    public void Clear() => Content = string.Empty;

    public void RemoveLast(int count)
    {
        if (count <= 0 || count > Content.Length)
        {
            return;
        }

        Content = Content[..^count];
    }
}
