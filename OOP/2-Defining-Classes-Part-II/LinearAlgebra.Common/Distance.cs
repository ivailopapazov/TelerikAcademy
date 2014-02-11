using System;

namespace LinearAlgebra.Common
{
    /// <summary>
    /// Represents Distance between objects.
    /// </summary>
    public static class Distance
    {
        /// <summary>
        /// Calculates euclidean distance between two points in 3D euclidean space.
        /// </summary>
        /// <param name="pointA">First point in 3D space.</param>
        /// <param name="pointB">Second point in 3D space.</param>
        /// <returns>Euclidean distance between two points.</returns>
        public static double Calculate(Point3D pointA, Point3D pointB)
        {
            // Take axis differences
            double diffX = pointA.X - pointB.X;
            double diffY = pointA.Y - pointB.Y;
            double diffZ = pointA.Z - pointB.Z;

            // Sum squared differences
            double squareSum = diffX * diffX + diffY * diffY + diffZ * diffZ;

            // Take the square root from the sum of the squared differences;
            double result = Math.Sqrt(squareSum);

            // Return value
            return result;
        }
    }
}
