using System;

class PrintIsoscelesTriangle
{
    static void Main()
    {
        char symbol = '\u00A9';
        int length = 0;
        Console.Write("Enter rows number for isosceles triangle(default is 3): ");
        bool isLength = int.TryParse(Console.ReadLine(), out length);
        length = isLength ? length : 3;
        Console.WriteLine("Printing isoscales triangle with {0} rows and {1} elements", length, Math.Pow(length, 2));
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine("{0," + (i + length) + "}", new string(symbol, 2 * i + 1));
        }
    }
}
