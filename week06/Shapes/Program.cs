using System;
class Program
{
    static void Main(string[] args)
    {
        Square square = new Square();
        square.SetColor("Yellow");
        square.SetSide(15);
        DisplayShapeinformation(square);

        Rectangle rectangle = new Rectangle();
        rectangle.SetColor("Blue");
        rectangle.SetLength(15);
        rectangle.SetWidth(4);
        DisplayShapeinformation(rectangle);

        Circle circle = new Circle();
        circle.SetColor("Green");
        circle.SetRadius(4);
        DisplayShapeinformation(circle);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            double area = shape.GetArea();
        }

    }
    
    public static void DisplayShapeinformation(Shape shape)
    {
    double area = shape.GetArea();
    Console.WriteLine($"Color: {shape.GetColor()}");
    Console.WriteLine($"Area: {area} square meters");
    }
}