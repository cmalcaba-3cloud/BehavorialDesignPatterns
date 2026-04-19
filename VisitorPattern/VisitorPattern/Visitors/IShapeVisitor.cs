using VisitorPattern.Elements;

namespace VisitorPattern.Visitors;

public interface IShapeVisitor<out T>
{
    T VisitCircle(Circle circle);
    T VisitRectangle(Rectangle rectangle);
}
