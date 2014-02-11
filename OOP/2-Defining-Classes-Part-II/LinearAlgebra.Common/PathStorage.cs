using System;
using System.IO;

namespace LinearAlgebra.Common
{
    /// <summary>
    /// Represents path storing capabilities.
    /// </summary>
    public static class PathStorage
    {
        private const string file = @"save.txt";

        /// <summary>
        /// Saves path data into file.
        /// </summary>
        /// <param name="path">Path that you want to save.</param>
        public static void Save(Path path)
        {
            // Clear file content
            File.WriteAllText(file, string.Empty);

            // Append line by line every point coordinates.
            using (StreamWriter output = File.AppendText(file))
            {
                foreach (Point3D point in path)
                {
                    output.WriteLine(point.ToString());
                }
            }
        }

        /// <summary>
        /// Loads path data from file.
        /// </summary>
        /// <returns>Stored path.</returns>
        public static Path Load()
        {
            // Declare new empty path
            Path loadedPath = new Path();

            // Read points from storage file 
            using (StreamReader input = new StreamReader(file))
            {
                // Read line by line and parse
                string line = input.ReadLine();
                while (line != null)
                {
                    // Parse line
                    Point3D point = Point3D.Parse(line);

                    // Add to path
                    loadedPath.AddPoint(point);

                    // Read next line
                    line = input.ReadLine();
                }
            }
            
            // Return path
            return loadedPath;
        }
    }
}
