using VisitorPattern.Visitors;

namespace VisitorPattern.Elements;

public class Rectangle : IShape
{
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double Width { get; }
    public double Height { get; }

    public T Accept<T>(IShapeVisitor<T> visitor) => visitor.VisitRectangle(this);
}
