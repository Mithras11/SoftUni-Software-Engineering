using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Shape rectangle = new Rectangle(4, 3);

            Console.WriteLine(rectangle.CalculateArea());
            Console.WriteLine(rectangle.CalculatePerimeter());
            Console.WriteLine(rectangle.Draw());

            Shape circle = new Circle(8);

            Console.WriteLine(circle.CalculateArea());
            Console.WriteLine(circle.CalculatePerimeter());
            Console.WriteLine(circle.Draw());

        }
    }
}
