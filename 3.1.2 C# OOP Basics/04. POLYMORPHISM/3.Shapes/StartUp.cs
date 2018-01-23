using System;

public class StartUp
{
    public static void Main()
    {
        Shape rectangle = new Rectangle(3, 4.3);
        Shape circle = new Circle(6.4);

        Console.WriteLine(rectangle.CalculateArea());
        Console.WriteLine(rectangle.CalculatePerimeter());
        Console.WriteLine(rectangle.Draw());

        Console.WriteLine(circle.CalculateArea());
        Console.WriteLine(circle.CalculatePerimeter());
        Console.WriteLine(circle.Draw());
    }
}
