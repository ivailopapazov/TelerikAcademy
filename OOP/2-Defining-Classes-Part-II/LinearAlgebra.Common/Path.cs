using System;
using System.Collections.Generic;

namespace LinearAlgebra.Common
{
    /// <summary>
    /// Represents sequence of points in 3D space.
    /// </summary>
    public class Path : IEnumerable<Point3D>
    {
        /// <summary>
        /// Holds path points of the instance.
        /// </summary>
        protected List<Point3D> points = new List<Point3D>();

        /// <summary>
        /// Adds a point to the path.
        /// </summary>
        /// <param name="point">Next point of the path.</param>
        public void AddPoint(Point3D point)
        {
            points.Add(point);
        }

        /// <summary>
        /// Removes specific point from the path.
        /// </summary>
        /// <param name="index">Index of the point.</param>
        public void RemovePoint(int index)
        {
            points.RemoveAt(index);
        }

        /// <summary>
        /// Gets or sets value at a specific index.
        /// </summary>
        /// <param name="index">Index of point.</param>
        /// <returns>3D Point object.</returns>
        public Point3D this[int index]
        {
            get
            {
                // Validate index
                if (index >= points.Count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Index is out of range.");
                }
                return points[index];
            }
            set
            {
                // Validate index
                if (index >= points.Count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Index is out of range.");
                }
                points[index] = value;
            }
        }

        // IEnumerable implementation.
        public IEnumerator<Point3D> GetEnumerator()
        {
            return points.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
