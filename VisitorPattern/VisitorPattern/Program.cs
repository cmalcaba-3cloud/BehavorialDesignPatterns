using VisitorPattern.Elements;
using VisitorPattern.Visitors;

Console.WriteLine("== Visitor Pattern: Shape Analysis ==\n");

var shapes = new IShape[] { new Circle(3), new Rectangle(4, 5) };
var areaVisitor = new AreaVisitor();
var descriptionVisitor = new DescriptionVisitor();

foreach (var shape in shapes)
{
    Console.WriteLine(shape.Accept(descriptionVisitor));
    Console.WriteLine($"Area: {shape.Accept(areaVisitor):F2}\n");
}
