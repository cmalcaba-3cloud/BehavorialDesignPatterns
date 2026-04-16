using IteratorPattern.Models;

namespace IteratorPattern.Iterators;

public class BookIterator : IBookIterator
{
    private readonly List<Book> _books;
    private int _index;

    public BookIterator(List<Book> books)
    {
        _books = books;
    }

    public bool HasNext() => _index < _books.Count;

    public Book Next() => _books[_index++];
}
