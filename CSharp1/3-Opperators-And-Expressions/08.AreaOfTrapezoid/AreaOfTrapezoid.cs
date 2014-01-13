using System;

class AreaOfTrapezoid
{
    static void Main()
    {
        Console.Write("Please enter side a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter side b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter height: ");
        double h = double.Parse(Console.ReadLine());
        double trapezoidArea = ((a + b) / 2) * h;
        Console.WriteLine("The area of trapezoid is equal to " + trapezoidArea);
    }
}
