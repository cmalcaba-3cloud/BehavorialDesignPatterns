using VisitorPattern.Elements;

namespace VisitorPattern.Visitors;

public class AreaVisitor : IShapeVisitor<double>
{
    public double VisitCircle(Circle circle) => Math.PI * circle.Radius * circle.Radius;

    public double VisitRectangle(Rectangle rectangle) => rectangle.Width * rectangle.Height;
}
