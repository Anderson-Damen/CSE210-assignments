using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square shape1 = new Square("Green", 3);
        shapes.Add(shape1);

        Rectangle shape2 = new Rectangle("Red", 4, 5);
        shapes.Add(shape2);

        Circle shape3 = new Circle("Blue", 6);
        shapes.Add(shape3);

        foreach (Shape shape in shapes)
        {
            string color =(shape.GetColor());
            double shape_area = (shape.GetArea());

            Console.WriteLine($"The shape color is {color} with an area of {shape_area}.");
        }
    }
}