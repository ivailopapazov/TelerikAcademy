using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeSurfaceCalculation
{
    /// <summary>
    /// Represents a Circle geometric figure.
    /// </summary>
    class Circle : Shape
    {

        /// <summary>
        /// Initializes new instance of Circle class specified by radius.
        /// </summary>
        /// <param name="radius">Circles radius.</param>
        public Circle(double radius)
            : base(radius, radius)
        {
        }

        /// <summary>
        /// Calculates the surface area of the circle.
        /// </summary>
        /// <returns></returns>
        public override double CalculateSurface()
        {
            // Width and height are equal.
            return this.width * this.height * Math.PI;
        }
    }
}
