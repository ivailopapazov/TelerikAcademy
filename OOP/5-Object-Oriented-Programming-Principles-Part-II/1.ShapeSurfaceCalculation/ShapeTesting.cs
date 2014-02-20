using System;
using System.Linq;

namespace ShapeSurfaceCalculation
{
    class ShapeTesting
    {
        static void Main()
        {
            // Initializes array of shapes.
            Shape[] shapes = new Shape[]
            {
                new Triangle(2, 3),
                new Rectangle(5, 4),
                new Circle(6),
            };

            // Print each shape surface area and it's data type.
            foreach (Shape shape in shapes)
            {
                Console.WriteLine("{0} instance has surface equal to {1}", shape.GetType(), shape.CalculateSurface());
            }
        }
    }
}
