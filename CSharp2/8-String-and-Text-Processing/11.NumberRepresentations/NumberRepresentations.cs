using System;

class NumberRepresentations
{
    static void Main()
    {
        // User input
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        // Print decimal
        Console.WriteLine("{0, 15:D}",number);

        // Print hexadecimal
        Console.WriteLine("{0, 15:X}", number);

        // Print percentage
        Console.WriteLine("{0, 15:P}", number);

        // Scientific notation
        Console.WriteLine("{0, 15:G2}", number);
    }
}
