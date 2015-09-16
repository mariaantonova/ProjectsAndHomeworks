using System;

namespace Shapes
{
    public class TestShapes
    {
        public static void Main()
        {
            IShape triangleA = new Triangle(5, 3.5, 6);
            IShape triangleB = new Triangle(6, 2.5, 4);
            IShape rect1 = new Rectangle(5, 3.5);
            IShape rect2 = new Rectangle(6, 2.5);
            IShape circle1 = new Circle(2.5);
            IShape circle2 = new Circle(2.1);

            IShape[] shapes = new IShape[6] {triangleA, triangleB, rect1, rect2, circle1, circle2};
            foreach (var shape in shapes)
	        {
		        Console.WriteLine("{0, -15}: Perimeter: {1:N2}, Area: {2:N2}",
                    shape.GetType().Name, shape.CalculatePerimeter(),
                    shape.CalculateArea());
	        }
        }
    }
}
