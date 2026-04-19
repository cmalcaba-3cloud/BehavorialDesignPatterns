using IteratorPattern.Iterators;
using IteratorPattern.Models;

namespace IteratorPattern.Collections;

public class BookCollection
{
    private readonly List<Book> _books = new();

    public void Add(Book book) => _books.Add(book);

    public IBookIterator CreateIterator() => new BookIterator(_books);
}
