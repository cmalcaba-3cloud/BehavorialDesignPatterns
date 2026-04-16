using VisitorPattern.Elements;

namespace VisitorPattern.Visitors;

public class DescriptionVisitor : IShapeVisitor<string>
{
    public string VisitCircle(Circle circle) => $"Circle (r={circle.Radius})";

    public string VisitRectangle(Rectangle rectangle) => $"Rectangle ({rectangle.Width}x{rectangle.Height})";
}
