using VisitorPattern.Visitors;

namespace VisitorPattern.Elements;

public class Circle : IShape
{
    public Circle(double radius)
    {
        Radius = radius;
    }

    public double Radius { get; }

    public T Accept<T>(IShapeVisitor<T> visitor) => visitor.VisitCircle(this);
}
