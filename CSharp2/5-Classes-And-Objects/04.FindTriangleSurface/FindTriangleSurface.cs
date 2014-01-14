using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Triangle
{
    // Class fields
    double surface; // the surface of triangle

    // Class constructor overloads
    public Triangle(double a, double b, double c) // Given three sides
    {
        // Using heron's formula SSS
        double halfP = (a + b + c) / 2;
        this.surface = Math.Sqrt(halfP * (halfP - a) * (halfP - b) * (halfP - c));
    }
    public Triangle(double side, double altitude) // given side and altitude to it
    {
        // Using formula (a*ha)/2
        this.surface = (side * altitude) / 2;
    }
    public Triangle(double a, string angle, double b) // given two sides and angle between them
    {
        // Parse angle
        double degrees = double.Parse(angle);

        // Convert degrees to radians
        double radians = degrees * Math.PI / 180;

        // Take sin 
        double angleSin = Math.Sin(radians);

        // Calculate surface
        this.surface = (a * b * angleSin) / 2;
    }

    // Class methods
    public override string ToString()
    {
        return Convert.ToString(this.surface);
    }
}
class FindTriangleSurface
{
    static void Main()
    {
        // User input
        Console.WriteLine("1: SSS (side side side)");
        Console.WriteLine("2: SAS (side angle side)");
        Console.WriteLine("3: Side and altitude to it");
        Console.Write("Select method: ");
        string choice = Console.ReadLine();

        // Declare variables
        double sideA, sideB, sideC, altitude;
        string angle; // to avoid ambiguous constructor overloads
        Triangle triangleSurface;

        // Switch case
        switch (choice)
        {
            case "1":
                Console.WriteLine("Enter three sides:");
                sideA = double.Parse(Console.ReadLine());
                sideB = double.Parse(Console.ReadLine());
                sideC = double.Parse(Console.ReadLine());
                // Create triangle object
                triangleSurface = new Triangle(sideA, sideB, sideC);
                // Print result
                Console.WriteLine(triangleSurface);
                break;
            case "2":
                Console.WriteLine("Enter two sides and angle between them:");
                sideA = double.Parse(Console.ReadLine());
                sideB = double.Parse(Console.ReadLine());
                angle = Console.ReadLine();
                // Create triangle object
                triangleSurface = new Triangle(sideA, angle, sideB);
                // Print result
                Console.WriteLine(triangleSurface);
                break;
            case "3":
                Console.WriteLine("Enter a side and altitude to it:");
                sideA = double.Parse(Console.ReadLine());
                altitude = double.Parse(Console.ReadLine());
                // Create triangle object
                triangleSurface = new Triangle(sideA, altitude);
                // Print result
                Console.WriteLine(triangleSurface);
                break;
            default:
                Console.WriteLine("Invalid method!");
                break;
        }
    }
}
