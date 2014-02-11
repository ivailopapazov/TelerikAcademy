using System;

namespace LinearAlgebra.Common
{
    /// <summary>
    /// Represents point in 3D space.
    /// </summary>
    public struct Point3D
    {
        /// <summary>
        /// Represents the origin of the Euclidean 3D space.
        /// </summary>
        private static readonly Point3D o = new Point3D(0, 0, 0);

        /// <summary>
        /// Initializes new instance of the Point3D structure to a specific point in 3D space.
        /// </summary>
        /// <param name="x">Represents position on X axis.</param>
        /// <param name="y">Represents position on Y axis.</param>
        /// <param name="z">Represents position on Z axis.</param>
        public Point3D(double x, double y, double z) : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        /// <summary>
        /// Gets the origin point of the Euclidean 3D space.
        /// </summary>
        public static Point3D O 
        {
            get
            {
                return o;
            } 
        }

        /// <summary>
        /// Gets the x axis position.
        /// </summary>
        public double X { get; private set; }

        /// <summary>
        /// Gets the y axis position.
        /// </summary>
        public double Y { get; private set; }

        /// <summary>
        /// Gets the Z axis position.
        /// </summary>
        public double Z { get; private set; }

        public static Point3D Parse(string input)
        {
            // Coordinate holder
            double[] coords = new double[3];

            // Split coordinates
            string[] strCoords = input.Split(new char[] { '{', '}', ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            // Validate coordinates count
            if (strCoords.Length != 3)
            {
                throw new FormatException("Invalid coordinates count.");
            }
            
            // Parse each coordinate
            for (int i = 0; i < strCoords.Length; i++)
            {
                if (!double.TryParse(strCoords[i], out coords[i]))
                {
                    throw new FormatException("Cannot parse Point3D");
                }
            }

            // Create new Point3D instance
            Point3D parsedPoint = new Point3D(coords[0], coords[1], coords[2]);

            // Return parsed value
            return parsedPoint;
        }

        /// <summary>
        /// Converts the value of the Point3D object into string representation of it's position in 3D coordinate system.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{{{0}, {1}, {2}}}", X, Y, Z);
        }

    }
}
