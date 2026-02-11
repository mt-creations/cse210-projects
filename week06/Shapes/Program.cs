using System;
using System.Diagnostics.Contracts;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>
        {
            new Square("Red", 4),
            new Square("Orange", 6),
            new Circle("Yellow", 4),
            new Circle("Green", 7),
            new Rectangle("Blue", 5, 6),
            new Rectangle("Blue", 12, 2)
        };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} {shape.GetType().Name} has an area of: {shape.GetArea():F2}");
        }

    }
}