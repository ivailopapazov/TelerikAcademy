using System;

class PointInCircle
{
    static void Main()
    {
        Console.Write("Please enter x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Please enter y: ");
        double y = double.Parse(Console.ReadLine());

        bool isPointInCircle = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) < 5;
        Console.WriteLine("The point ({0},{1}) {2} in circle K(0,5)", x , y, isPointInCircle ? "is" : "is not");

    }
}
