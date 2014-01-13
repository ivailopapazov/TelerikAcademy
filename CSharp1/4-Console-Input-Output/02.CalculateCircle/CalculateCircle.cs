using System;

class CalculateCircle
{
    static void Main()
    {
        Console.Write("Please enter circle's radius: ");
        double radius = double.Parse(Console.ReadLine());

        double circumference = 2 * Math.PI * radius;
        double area = Math.PI * Math.Pow(radius, 2);

        Console.WriteLine("Circumference of the circle is equal to {0:F3} ", circumference);
        Console.WriteLine("Area of the circle is equal to {0:F3}", area);
    }
}
