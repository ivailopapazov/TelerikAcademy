using System;

class AreaOfRectangle
{
    static void Main()
    {
        Console.Write("Please enter the height: ");
        double  height = double.Parse(Console.ReadLine());
        Console.Write("Please enter the width: ");
        double  width = double.Parse(Console.ReadLine());
        double area = height * width;
        Console.WriteLine("The area of rectangle {0} by {1} is equal to {2}", height, width, area);
    }
}
