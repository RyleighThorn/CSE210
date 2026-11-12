using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shape = new List<Shape>();
        Square s1 = new Square("blue", 2);
        shape.Add(s1);

        Rectangle s2 = new Rectangle("green", 2, 4);
        shape.Add(s2);

        Circle s3 = new Circle("Red", 3);
        shape.Add(s3);

        foreach(Shape s in shape)
        {
            string color = s.getColor();
            double area = s.getArea();

            Console.WriteLine($"the color of the shape is {color}, the area is {area}.");
        }
    }
}