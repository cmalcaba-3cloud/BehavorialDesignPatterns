using MementoPattern.Caretakers;
using MementoPattern.Originators;

Console.WriteLine("== Memento Pattern: Text Editor History ==\n");

var editor = new TextEditor();
var history = new History();

editor.Write("Hello");
history.Push(editor.CreateSnapshot());

editor.Write(", world!");
Console.WriteLine($"Current: {editor.Content}");

editor.Restore(history.Pop());
Console.WriteLine($"Restored: {editor.Content}");
