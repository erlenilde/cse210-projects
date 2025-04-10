using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("blue", 2);
        Rectangle rectangle = new Rectangle("green", 4, 2);
        Circle circle = new Circle("yellow", 3);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach(Shape shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} shape has an area of {shape.GetArea()}");
        }

        
    }
}