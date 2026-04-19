using IteratorPattern.Collections;
using IteratorPattern.Models;

Console.WriteLine("== Iterator Pattern: Library ==\n");

var books = new BookCollection();
books.Add(new Book("Clean Code"));
books.Add(new Book("Refactoring"));
books.Add(new Book("Domain-Driven Design"));

var iterator = books.CreateIterator();
while (iterator.HasNext())
{
    Console.WriteLine(iterator.Next().Title);
}
