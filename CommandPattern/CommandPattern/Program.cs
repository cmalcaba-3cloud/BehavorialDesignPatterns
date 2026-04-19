using CommandPattern.Commands;
using CommandPattern.Invokers;
using CommandPattern.Receivers;

Console.WriteLine("== Command Pattern: Text Editor ==\n");

var document = new TextDocument();
var menu = new MenuInvoker();

menu.Execute(new WriteTextCommand(document, "Hello"));
menu.Execute(new WriteTextCommand(document, " Design Patterns"));
menu.Execute(new ClearTextCommand(document));
menu.UndoLast();

Console.WriteLine(document.Content);
