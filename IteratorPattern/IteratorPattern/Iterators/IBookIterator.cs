using IteratorPattern.Models;

namespace IteratorPattern.Iterators;

public interface IBookIterator
{
    bool HasNext();
    Book Next();
}
