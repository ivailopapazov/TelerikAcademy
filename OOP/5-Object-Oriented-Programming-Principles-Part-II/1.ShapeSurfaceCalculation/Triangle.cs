using System;
using System.Linq;

namespace ShapeSurfaceCalculation
{
    /// <summary>
    /// Represents a triangle geometric figure.
    /// </summary>
    class Triangle : Shape
    {

        /// <summary>
        /// Initializes new instance of Triangle class to the specified width and height of the triangle.
        /// </summary>
        /// <param name="width">Triangle's width.</param>
        /// <param name="height">Triangle's height.</param>
        public Triangle(double width, double height)
            : base(width, height)
        {
        }

        /// <summary>
        /// Calculates the surface of the triangle.
        /// </summary>
        /// <returns>Triangle's surface.</returns>
        public override double CalculateSurface()
        {
            return (this.width * this.height) / 2;
        }
    }
}
