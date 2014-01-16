using System;

class SquareRoot
{
    static void Main()
    {
        // User input
        Console.Write("Enter positive number: ");

        try
        {
            // Parse number
            int number = int.Parse(Console.ReadLine());

            // If negative number throw exception
            if (number < 0)
	        {
		        throw new FormatException();
	        }

            // Calculate square root
            double squareRoot = Math.Sqrt(number);

            // Print result
            Console.WriteLine(squareRoot);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number!");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}
