using System;

class CartesianPoint
{
    static void Main()
    {
        Console.Write("Please enter x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Please enter y: ");
        double y = double.Parse(Console.ReadLine());

        bool isInCircle = Math.Pow((x - 1), 2) + Math.Pow((y - 1), 2) <= Math.Pow(3, 2);
        bool isInRectangle = x > -1 && x < 5 && Math.Abs(y) < 1;

        if (isInCircle && !isInRectangle) // True if point is in circle and not in rectangle
        {
            Console.WriteLine("True - Point is in circle and out of the rectangle!");
        }
        else if (isInCircle && isInRectangle)
        {
            Console.WriteLine("False - Point is in circle but it is also in rectangle!");
        }
        else
        {
            Console.WriteLine("False - Point is not in circle!");
        }
    }
}
