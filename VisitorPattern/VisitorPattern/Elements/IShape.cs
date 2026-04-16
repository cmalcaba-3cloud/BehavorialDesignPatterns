using VisitorPattern.Visitors;

namespace VisitorPattern.Elements;

public interface IShape
{
    T Accept<T>(IShapeVisitor<T> visitor);
}
