using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("blue", 2);
        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());

        Rectangle rectangle = new Rectangle("green", 2, 2);
        Console.WriteLine(rectangle.GetColor());
        Console.WriteLine(rectangle.GetArea());

        Circle circle = new Circle("red", 2);
        Console.WriteLine(circle.GetColor());
        Console.WriteLine(circle.GetArea());
    }
}